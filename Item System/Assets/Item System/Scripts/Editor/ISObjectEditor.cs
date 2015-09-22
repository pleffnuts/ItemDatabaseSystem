using UnityEngine;
using UnityEditor;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor : EditorWindow
	{
		enum DisplayState
		{
			DisplayNothing,
			DisplayDatabaseEntry,
			EditDatabaseEntry,
			CreateDatabaseEntry,
			DisplayOther
		}

		//DON'T Change values of this enum. Using integer references in Display Details. Main Databases are <100, prerequisite <200, other screens >200.
		//Only add to enum, DO NOT change values of current entries without carfeully checking code.
		enum MenuSelection
		{
			CommonItemDb 		= 1,
			WeaponsDb			= 2,
			ArmorDb				= 3,
			PotionsDb			= 4,
			BooksDb				= 5,
			ScrollsDb			= 6,
			CraftMatsDb			= 7,

			CharacterClassDb	= 101,
			CharacterStatsDb	= 102,
			ItemQualitiesDb		= 103,
			ArmorTypesDb		= 104,
			WeaponTypesDb		= 105,
			AttackTypesDb		= 106,
			ArmorLocationsDb	= 107,

			SearchScreen		= 201,
			HelpScreen			= 202,
			RemoveDatabaseScreen= 203,
			AboutScreen			= 204
		}

		MenuSelection 				menuSelection					= MenuSelection.AboutScreen;				//State of what is displayed in ListView and Main Display Pane
		DisplayState				displayState 					= DisplayState.DisplayOther;				//State of how data is presented in Main Display Pane and associated buttons

		ISWeapon 					_tempWeapon 					= new ISWeapon();							//Used in display pane
		ISArmor						_tempArmor						= new ISArmor();							//Used in display pane
		ISObject					_tempItem						= new ISObject();							//Used in display pane

		ISQuality					_tempQuality					= new ISQuality();							//Used in display pane
		ISQuality					_tempQualityOld					= new ISQuality();							//Used in resetting item qualities
		bool						_isQualityOldUpdated			= false;									//Used in resetting item qualities
		int  						_qualitySelectedIndex 			= 0;										//Used for making selections from quality levels
		string[] 					_qualityOptions;															//Used for loading selections from quality levels
		bool						_qualityOptionsLoaded			= false;									//Used to ensure quality selections are loaded

		ISWeaponType				_tempWeaponType					= new ISWeaponType();						//Used in display pane
		ISWeaponType				_tempWeaponTypeOld				= new ISWeaponType();						//Used in resetting weapon types
		bool						_isWeaponTypeOldUpdated			= false;									//Used in resetting weapon types
		int  						_weaponTypeSelectedIndex 		= 0;										//Used for making selections from weapon types
		string[]					_weaponTypeOptions;															//Used for loading selections from weapon types
		bool						_weaponTypeOptionsLoaded		= false;									//Used to ensure weapon type selections are loaded

		ISAttackType				_tempAttackType					= new ISAttackType();						//Used in display pane
		ISAttackType				_tempAttackTypeOld				= new ISAttackType();						//Used in resetting attack types
		bool						_isAttackTypeOldUpdated			= false;									//Used in resetting attack types
		int  						_attackTypeSelectedIndex 		= 0;										//Used for making selections from attack types
		string[]					_attackTypeOptions;															//Used for loading selections from attack types
		bool						_attackTypeOptionsLoaded		= false;									//Used to ensure attack type selections are loaded

		ISArmorType					_tempArmorType					= new ISArmorType();						//Used in display pane
		ISArmorType					_tempArmorTypeOld				= new ISArmorType();						//Used in resetting armor types
		bool						_isArmorTypeOldUpdated			= false;									//Used in resetting armor types
		int  						_armorTypeSelectedIndex 		= 0;										//Used for making selections from armor types
		string[]					_armorTypeOptions;															//Used for loading selections from armor types
		bool						_armorTypeOptionsLoaded			= false;									//Used to ensure armor type selections are loaded

		ISArmorLocation				_tempArmorLocation				= new ISArmorLocation();					//Used in display pane
		ISArmorLocation				_tempArmorLocationOld			= new ISArmorLocation();					//Used in resetting armor locations
		bool						_isArmorLocationOldUpdated		= false;									//Used in resetting armor locations
		int  						_armorLocationSelectedIndex 	= 0;										//Used for making selections from armor locations
		string[]					_armorLocationOptions;														//Used for loading selections from armor locations
		bool						_armorLocationOptionsLoaded		= false;									//Used to ensure armor location selections are loaded

		Vector2  					_scrollPosition 				= Vector2.zero; 							//Used in List View
		int							_listViewWidth 					= 200;										//Used in List View
		int 						_listViewButtonWidth 			= 190;										//Used in List View
		int							_listViewButtonHeight 			= 20;										//Used in List View
		int							_selectedIndex 					= -1;										//Used in List View

		ISObjectDatabase			_commonItemDatabase;
		ISWeaponDatabase 			_weaponDatabase;
		ISArmorDatabase				_armorDatabase;

		ISQualityDatabase			_qualityDatabase;
		ISWeaponTypeDatabase		_weaponTypeDatabase;
		ISAttackTypeDatabase		_attackTypeDatabase;
		ISArmorTypeDatabase			_armorTypeDatabase;
		ISArmorLocationDatabase		_armorLocationDatabase;
			
		const string 				DATABASE_FOLDER_NAME				= @"Database";

		const string				COMMON_ITEMS_DATABASE_FILE_NAME 	= @"PlefnutsObjectDatabase.asset";
		const string 				WEAPON_DATABASE_FILE_NAME			= @"PlefnutsWeaponDatabase.asset";
		const string				ARMOR_DATABASE_FILE_NAME			= @"PlefnutsArmorDatabase.asset";
		const string				QUALITY_DATABASE_FILE_NAME			= @"PlefnutsQualityDatabase.asset";
		const string 				WEAPON_TYPE_DATABASE_FILE_NAME		= @"PlefnutsWeaponTypeDatabase.asset";
		const string 				ATTACK_TYPE_DATABASE_FILE_NAME		= @"PlefnutsAttackTypeDatabase.asset";
		const string 				ARMOR_TYPE_DATABASE_FILE_NAME		= @"PlefnutsArmorTypeDatabase.asset";
		const string 				ARMOR_LOCATION_DATABASE_FILE_NAME	= @"PlefnutsArmorLocationDatabase.asset";

		GUIStyle					modifiedGUIStyle				= new GUIStyle();

		[MenuItem("Plefnuts/Database/Item System Editor %#i")]
		public static void Init()
		{
			ISObjectEditor window = EditorWindow.GetWindow<ISObjectEditor> ();
			
			window.minSize = new Vector2 (800, 600);
			window.titleContent.text = "Item System";
			window.Show ();
		}

		void OnEnable()
		{
			//Primary Databases
			if(_commonItemDatabase == null)
			{
				_commonItemDatabase = ISObjectDatabase.GetDatabase<ISObjectDatabase>(DATABASE_FOLDER_NAME, COMMON_ITEMS_DATABASE_FILE_NAME);
			}
			if(_weaponDatabase == null)
			{
				_weaponDatabase = ISWeaponDatabase.GetDatabase<ISWeaponDatabase>(DATABASE_FOLDER_NAME, WEAPON_DATABASE_FILE_NAME);
			}
			if(_armorDatabase == null)
			{
				_armorDatabase = ISArmorDatabase.GetDatabase<ISArmorDatabase>(DATABASE_FOLDER_NAME, ARMOR_DATABASE_FILE_NAME);
			}

			//Prerequisite Databases
			if(_qualityDatabase == null)
			{
				_qualityDatabase = ISQualityDatabase.GetDatabase<ISQualityDatabase>(DATABASE_FOLDER_NAME, QUALITY_DATABASE_FILE_NAME);
			}
			if(_weaponTypeDatabase == null)
			{
				_weaponTypeDatabase = ISWeaponTypeDatabase.GetDatabase<ISWeaponTypeDatabase>(DATABASE_FOLDER_NAME, WEAPON_TYPE_DATABASE_FILE_NAME);
			}
			if(_attackTypeDatabase == null)
			{
				_attackTypeDatabase = ISAttackTypeDatabase.GetDatabase<ISAttackTypeDatabase>(DATABASE_FOLDER_NAME, ATTACK_TYPE_DATABASE_FILE_NAME);
			}
			if(_armorTypeDatabase == null)
			{
				_armorTypeDatabase = ISArmorTypeDatabase.GetDatabase<ISArmorTypeDatabase>(DATABASE_FOLDER_NAME, ARMOR_TYPE_DATABASE_FILE_NAME);
			}
			if(_armorLocationDatabase == null)
			{
				_armorLocationDatabase = ISArmorLocationDatabase.GetDatabase<ISArmorLocationDatabase>(DATABASE_FOLDER_NAME, ARMOR_LOCATION_DATABASE_FILE_NAME);
			}

			LoadPrereqDatabaseOptions ();
		}

		void OnGUI()
		{
			TopMenuBar ();

			GUILayout.BeginHorizontal ();

			ListViewPane ();
			PrimaryDisplayPane ();
			GUILayout.EndHorizontal ();

			BottomStatusBar ();
		}

		void NullTempEntries()
		{
			_tempWeapon 					= null;
			_tempArmor						= null;
			_tempItem						= null;	
			
			_tempQuality					= null;	
			_tempQualityOld					= null;

			_tempWeaponType					= null;	
			_tempWeaponTypeOld				= null;

			_tempAttackType					= null;	
			_tempAttackTypeOld				= null;

			_tempArmorType					= null;	
			_tempArmorTypeOld				= null;	
		
			_tempArmorLocation				= null;	
			_tempArmorLocationOld			= null;	
		}
	}
}
