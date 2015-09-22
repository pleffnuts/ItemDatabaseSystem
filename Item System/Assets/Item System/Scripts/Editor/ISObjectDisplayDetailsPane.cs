using UnityEngine;
using UnityEditor;
using System.Collections;
using System;
namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void PrimaryDisplayPane()
		{
			GUILayout.BeginVertical ("Box", GUILayout.ExpandWidth (true), GUILayout.ExpandHeight (true));
			GUILayout.BeginVertical (GUILayout.ExpandWidth (true), GUILayout.ExpandHeight(true));

			DisplayInformation ();

			GUILayout.EndVertical ();

			GUILayout.Space (50);
			if(displayState != DisplayState.DisplayOther)
			{
				GUILayout.BeginHorizontal (GUILayout.ExpandWidth (true));
				DisplayButtons ();
				GUILayout.EndHorizontal ();
			}

			GUILayout.EndVertical ();
		}

		void DisplayInformation()
		{			
			switch(menuSelection)
			{
			case MenuSelection.WeaponsDb:
				DisplayWeaponsWindow();
				break;
			case MenuSelection.ArmorDb:
				DisplayArmorWindow();
				break;
			case MenuSelection.PotionsDb:
				DisplayPotionsWindow();
				break;
			case MenuSelection.ScrollsDb:
				DisplayScrollsWindow();
				break;
			case MenuSelection.BooksDb:
				DisplayBooksWindow();
				break;
			case MenuSelection.CommonItemDb:
				DisplayCommonItemsWindow();
				break;
			case MenuSelection.CraftMatsDb:
				DisplayCraftMatsWindow();
				break;
			case MenuSelection.CharacterClassDb:
				DisplayCharacterClassesWindow();
				break;
			case MenuSelection.CharacterStatsDb:
				DisplayCharacterStatsWindow();
				break;
			case MenuSelection.ArmorTypesDb:
				DisplayArmorTypesWindow();
				break;
			case MenuSelection.ArmorLocationsDb:
				DisplayArmorLocationsWindow();
				break;
			case MenuSelection.WeaponTypesDb:
				DisplayWeaponTypesWindow();
				break;
			case MenuSelection.AttackTypesDb:
				DisplayAttackTypesWindow();
				break;
			case MenuSelection.ItemQualitiesDb:
				DisplayItemQualityTypesWindow();
				break;
			case MenuSelection.HelpScreen:
				DisplayHelpScreen();
				break;
			case MenuSelection.RemoveDatabaseScreen:
				DisplayRemoveDatabaseScreen();
				break;
			case MenuSelection.SearchScreen:
				DisplaySearchScreen();
				break;
			case MenuSelection.AboutScreen:
				DisplayAboutScreen();
				break;
			}
		}

		void DisplayWeaponsWindow()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				ViewWeapon();
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				EditWeapon();
			}
		}

		void DisplayArmorWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				ViewArmor();
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				EditArmor();
			}
		}

		void DisplayPotionsWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				GUILayout.Label("Displaying Potion");
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				GUILayout.Label("Creating or Editing Potion");
			}
		}

		void DisplayScrollsWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				GUILayout.Label("Displaying Scroll");
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				GUILayout.Label("Creating or Editing Scroll");
			}
		}

		void DisplayBooksWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				GUILayout.Label("Displaying Book");
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				GUILayout.Label("Creating or Editing Book");
			}
		}

		void DisplayCommonItemsWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				ViewCommonItem();
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				EditCommonItem();
			}
		}

		void DisplayCraftMatsWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				GUILayout.Label("Displaying Crafting Material");
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				GUILayout.Label("Creating or Editing Crafting Material");
			}
		}

		void DisplayCharacterClassesWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				GUILayout.Label("Displaying Character Class");
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				GUILayout.Label("Creating or Editing Character Class");
			}
		}

		void DisplayCharacterStatsWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				GUILayout.Label("Displaying Character Stat");
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				GUILayout.Label("Creating or Editing Character Stat");
			}
		}

		void DisplayArmorTypesWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				ViewArmorType();
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				EditArmorType();
			}
		}

		void DisplayArmorLocationsWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				ViewArmorLocation();
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				EditArmorLocation();
			}
		}

		void DisplayWeaponTypesWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				ViewWeaponType();
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				EditWeaponType();
			}
		}

		void DisplayAttackTypesWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				ViewAttackType();
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				EditAttackType();
			}
		}
		
		void DisplayItemQualityTypesWindow ()
		{
			if(displayState == DisplayState.DisplayDatabaseEntry)
			{
				ViewItemQuality();
			}
			else if(displayState == DisplayState.CreateDatabaseEntry || displayState == DisplayState.EditDatabaseEntry)
			{
				EditItemQuality();
			}
		}

		void DisplayHelpScreen ()
		{
			ViewHelpScreen ();
		}

		void DisplayRemoveDatabaseScreen ()
		{
			GUILayout.Label("Displaying Database Removal Screen");
		}

		void DisplaySearchScreen ()
		{
			GUILayout.Label("Displaying Search Screen");
		}

		void DisplayAboutScreen ()
		{
			ViewAboutScreen ();
		}

		void DisplayButtons()
		{
			switch(menuSelection)
			{
			case MenuSelection.WeaponsDb:
				DisplayWeaponButtons();
				break;
			case MenuSelection.ArmorDb:
				DisplayArmorButtons();
				break;
			case MenuSelection.PotionsDb:
				DisplayPotionButtons();
				break;
			case MenuSelection.ScrollsDb:
				DisplayScrollButtons();
				break;
			case MenuSelection.BooksDb:
				DisplayBookButtons();
				break;
			case MenuSelection.CommonItemDb:
				DisplayCommonItemButtons();
				break;
			case MenuSelection.CraftMatsDb:
				DisplayCraftMatButtons();
				break;
			case MenuSelection.CharacterClassDb:
				DisplayCharacterClassButtons();
				break;
			case MenuSelection.CharacterStatsDb:
				DisplayCharacterStatButtons();
				break;
			case MenuSelection.ArmorTypesDb:
				DisplayArmorTypeButtons();
				break;
			case MenuSelection.ArmorLocationsDb:
				DisplayArmorLocationButtons();
				break;
			case MenuSelection.WeaponTypesDb:
				DisplayWeaponTypeButtons();
				break;
			case MenuSelection.AttackTypesDb:
				DisplayAttackTypeButtons();
				break;
			case MenuSelection.ItemQualitiesDb:
				DisplayItemQualityButtons();
				break;
			}
		}

		void DisplayCommonItemButtons ()
		{
			switch(displayState)
			{
			case DisplayState.DisplayDatabaseEntry:
				if(GUILayout.Button("Edit"))
				{
					CreateButton(menuSelection, false);
				}
				if(GUILayout.Button("Copy"))
				{
					CreateButton(menuSelection, true);
				}
				if(GUILayout.Button("Delete"))
				{
					DeleteButton(_commonItemDatabase, menuSelection, _tempItem.Name);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.CreateDatabaseEntry:
				if(GUILayout.Button("Save"))
				{
					if(IsItemFormComplete(_tempItem)) SaveButton(_commonItemDatabase, menuSelection, _tempItem);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.EditDatabaseEntry:
				if(GUILayout.Button("Replace"))
				{
					if(IsItemFormComplete(_tempItem)) ReplaceButton(_commonItemDatabase, menuSelection, _tempItem);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(true);
				}
				break;
			case DisplayState.DisplayNothing:
				if(GUILayout.Button("Create"))
				{
					CreateButton(menuSelection, true);
				}
				break;
			default:
				break;
			}
		}

		void DisplayWeaponButtons()
		{
			switch(displayState)
			{
			case DisplayState.DisplayDatabaseEntry:
				if(GUILayout.Button("Edit"))
				{
					CreateButton(menuSelection, false);
				}
				if(GUILayout.Button("Copy"))
				{
					CreateButton(menuSelection, true);
				}
				if(GUILayout.Button("Delete"))
				{
					DeleteButton(_weaponDatabase, menuSelection, _tempWeapon.Name);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.CreateDatabaseEntry:
				if(GUILayout.Button("Save"))
				{
					if(IsWeaponFormComplete(_tempWeapon)) SaveButton(_weaponDatabase, menuSelection, _tempWeapon);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.EditDatabaseEntry:
				if(GUILayout.Button("Replace"))
				{					
					if(IsWeaponFormComplete(_tempWeapon)) ReplaceButton(_weaponDatabase, menuSelection, _tempWeapon);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(true);
				}
				break;
			case DisplayState.DisplayNothing:
				if(GUILayout.Button("Create"))
				{
					CreateButton(menuSelection, true);
				}
				break;
			default:
				break;
			}
		}
		
		void DisplayArmorButtons ()
		{
			switch(displayState)
			{
			case DisplayState.DisplayDatabaseEntry:
				if(GUILayout.Button("Edit"))
				{
					CreateButton(menuSelection, false);
				}
				if(GUILayout.Button("Copy"))
				{
					CreateButton(menuSelection, true);
				}
				if(GUILayout.Button("Delete"))
				{
					DeleteButton(_armorDatabase, menuSelection, _tempArmor.Name);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.CreateDatabaseEntry:
				if(GUILayout.Button("Save"))
				{
					if(IsArmorFormComplete(_tempArmor)) SaveButton(_armorDatabase, menuSelection, _tempArmor);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.EditDatabaseEntry:
				if(GUILayout.Button("Replace"))
				{					
					if(IsArmorFormComplete(_tempArmor)) ReplaceButton(_armorDatabase, menuSelection, _tempArmor);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(true);
				}
				break;
			case DisplayState.DisplayNothing:
				if(GUILayout.Button("Create"))
				{
					CreateButton(menuSelection, true);
				}
				break;
			default:
				break;
			}
		}
		
		void DisplayPotionButtons ()
		{
		}
		
		void DisplayScrollButtons ()
		{
		}
		
		void DisplayBookButtons ()
		{
		}
		
		void DisplayCraftMatButtons ()
		{
		}

		void DisplayCharacterClassButtons ()
		{
		}

		void DisplayCharacterStatButtons ()
		{
		}

		void DisplayArmorTypeButtons ()
		{
			switch(displayState)
			{
			case DisplayState.DisplayDatabaseEntry:
				if(GUILayout.Button("Edit"))
				{
					CreateButton(menuSelection, false);
				}
				if(GUILayout.Button("Copy"))
				{
					CreateButton(menuSelection, true);
				}
				if(GUILayout.Button("Delete"))
				{
					DeleteButton(_armorTypeDatabase, menuSelection, _tempArmorType.Name);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.CreateDatabaseEntry:
				if(GUILayout.Button("Save"))
				{
					SaveButton(_armorTypeDatabase, menuSelection, _tempArmorType);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.EditDatabaseEntry:
				if(GUILayout.Button("Replace"))
				{
					ReplaceButton(_armorTypeDatabase, menuSelection, _tempArmorType);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(true);
				}
				break;
			case DisplayState.DisplayNothing:
				if(GUILayout.Button("Create"))
				{
					CreateButton(menuSelection, true);
				}
				break;
			default:
				break;
			}
		}

		void DisplayArmorLocationButtons ()
		{
			switch (displayState) {
			case DisplayState.DisplayDatabaseEntry:
				if (GUILayout.Button ("Edit")) {
					CreateButton (menuSelection, false);
				}
				if (GUILayout.Button ("Copy")) {
					CreateButton (menuSelection, true);
				}
				if (GUILayout.Button ("Delete")) {
					DeleteButton (_armorLocationDatabase, menuSelection, _tempArmorLocation.Name);
				}
				if (GUILayout.Button ("Cancel")) {
					CancelButton (false);
				}
				break;
			case DisplayState.CreateDatabaseEntry:
				if (GUILayout.Button ("Save")) {
					SaveButton (_armorLocationDatabase, menuSelection, _tempArmorLocation);
				}
				if (GUILayout.Button ("Cancel")) {
					CancelButton (false);
				}
				break;
			case DisplayState.EditDatabaseEntry:
				if (GUILayout.Button ("Replace")) {
					ReplaceButton (_armorLocationDatabase, menuSelection, _tempArmorLocation);
				}
				if (GUILayout.Button ("Cancel")) {
					CancelButton (true);
				}
				break;
			case DisplayState.DisplayNothing:
				if (GUILayout.Button ("Create")) {
					CreateButton (menuSelection, true);
				}
				break;
			default:
				break;
			}
		}

		void DisplayWeaponTypeButtons ()
		{
			switch(displayState)
			{
			case DisplayState.DisplayDatabaseEntry:
				if(GUILayout.Button("Edit"))
				{
					CreateButton(menuSelection, false);
				}
				if(GUILayout.Button("Copy"))
				{
					CreateButton(menuSelection, true);
				}
				if(GUILayout.Button("Delete"))
				{
					DeleteButton(_weaponTypeDatabase, menuSelection, _tempWeaponType.Name);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.CreateDatabaseEntry:
				if(GUILayout.Button("Save"))
				{
					SaveButton(_weaponTypeDatabase, menuSelection, _tempWeaponType);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.EditDatabaseEntry:
				if(GUILayout.Button("Replace"))
				{
					ReplaceButton(_weaponTypeDatabase, menuSelection, _tempWeaponType);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(true);
				}
				break;
			case DisplayState.DisplayNothing:
				if(GUILayout.Button("Create"))
				{
					CreateButton(menuSelection, true);
				}
				break;
			default:
				break;
			}
		}

		void DisplayAttackTypeButtons ()
		{
			switch(displayState)
			{
			case DisplayState.DisplayDatabaseEntry:
				if(GUILayout.Button("Edit"))
				{
					CreateButton(menuSelection, false);
				}
				if(GUILayout.Button("Copy"))
				{
					displayState = DisplayState.CreateDatabaseEntry;
				}
				if(GUILayout.Button("Delete"))
				{
					DeleteButton(_attackTypeDatabase, menuSelection, _tempAttackType.Name);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.CreateDatabaseEntry:
				if(GUILayout.Button("Save"))
				{
					SaveButton(_attackTypeDatabase, menuSelection, _tempAttackType);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.EditDatabaseEntry:
				if(GUILayout.Button("Replace"))
				{
					ReplaceButton(_attackTypeDatabase, menuSelection, _tempAttackType);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(true);
				}
				break;
			case DisplayState.DisplayNothing:
				if(GUILayout.Button("Create"))
				{
					CreateButton(menuSelection, true);
				}
				break;
			default:
				break;
			}
		}

		void DisplayItemQualityButtons ()
		{
			switch(displayState)
			{
			case DisplayState.DisplayDatabaseEntry:
				if(GUILayout.Button("Edit"))
				{
					CreateButton(menuSelection, false);
				}
				if(GUILayout.Button("Copy"))
				{
					CreateButton(menuSelection, true);
				}
				if(GUILayout.Button("Delete"))
				{
					DeleteButton(_qualityDatabase, menuSelection, _tempQuality.Name);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false);
				}
				break;
			case DisplayState.CreateDatabaseEntry:
				if(GUILayout.Button("Save"))
				{
					SaveButton(_qualityDatabase, menuSelection, _tempQuality);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(false); 
				}
				break;
			case DisplayState.EditDatabaseEntry:
				if(GUILayout.Button("Replace"))
				{
					ReplaceButton(_qualityDatabase, menuSelection, _tempQuality);
				}
				if(GUILayout.Button("Cancel"))
				{
					CancelButton(true);
				}
				break;
			case DisplayState.DisplayNothing:
				if(GUILayout.Button("Create"))
				{
					CreateButton(menuSelection, true);
				}
				break;
			default:
				break;
			}
		}

		void SaveButton<T> (ScriptableObjectDatabase<T> database, MenuSelection selection, T objectToAdd) where T : ISBaseObject
		{
			string tempName = "";
			bool 	nameFound = false;
			for(int i = 0; i < database.Count; i++)
			{
				if(objectToAdd.Name == database.Get(i).Name)
				{
					nameFound = true;
				}
			}
			if(nameFound)
			{
				EditorUtility.DisplayDialog("Name already used",
				                            "You must give the item a unique name before saving.",
				                            "Okay");
				return;
			}
			else if(objectToAdd.Name == "" || objectToAdd.Name == null)
			{
				EditorUtility.DisplayDialog("Item not named",
				                            "You must give the item a name before saving.",
				                            "Okay");
				return;
			}

			database.Add(objectToAdd);
			NullTempEntries ();
			LoadPrereqDatabaseOptions();
			displayState = DisplayState.DisplayNothing;
		}

		void CreateButton (MenuSelection selection, bool isCreate)
		{
			if((int)menuSelection < 100)											//All prereq databases are above 100 and don't need to check this
			{
				if(!IsQualityOptionsLoaded()) return;
			}

			switch(menuSelection)
			{
			case MenuSelection.WeaponsDb:
				if(!IsWeaponTypeOptionsLoaded()) return;
				if(!IsAttackTypeOptionsLoaded()) return;
				if(isCreate) _tempWeapon = new ISWeapon();
				break;
			case MenuSelection.ArmorDb:
				if(!IsArmorLocationOptionsLoaded()) return;
				if(!IsArmorTypeOptionsLoaded()) return;
				if(isCreate) _tempArmor = new ISArmor();
				break;
			case MenuSelection.ItemQualitiesDb:
				if(isCreate) _tempQuality = new ISQuality();
				break;
			case MenuSelection.WeaponTypesDb:
				if(isCreate) _tempWeaponType = new ISWeaponType();
				break;
			case MenuSelection.AttackTypesDb:
				if(isCreate) _tempAttackType = new ISAttackType();
				break;
			case MenuSelection.ArmorTypesDb:
				if(isCreate) _tempArmorType = new ISArmorType();
				break;
			case MenuSelection.ArmorLocationsDb:
				if(isCreate) _tempArmorLocation = new ISArmorLocation();
				break;
			}

			if(isCreate)
			{
				displayState = DisplayState.CreateDatabaseEntry;
			}
			else
			{
				displayState = DisplayState.EditDatabaseEntry;
			}
		}

		void ReplaceButton<T> (ScriptableObjectDatabase<T> database, MenuSelection selection, T replacementObject) where T : ISBaseObject
		{
			if((int)selection < 100)
			{
				database.Replace(_selectedIndex, replacementObject);
				NullTempEntries ();
				displayState = DisplayState.DisplayNothing;
				return;
			}

			bool itemFound = false;
			int itemsUpdatedCount = 0;

			switch(selection)
			{
			case MenuSelection.ItemQualitiesDb:
				for(int i = 0; i < _weaponDatabase.Count; i++)
				{
					if(_weaponDatabase.Get(i).Quality.IsEqual(_tempQualityOld))
					{
						itemFound = true;
						_weaponDatabase.Get(i).Quality = _tempQuality;
						itemsUpdatedCount++;
					}
				}
				for(int i = 0; i < _commonItemDatabase.Count; i++)
				{
					if(_commonItemDatabase.Get(i).Quality.IsEqual(_tempQualityOld))
					{
						itemFound = true;
						_commonItemDatabase.Get(i).Quality = _tempQuality;
						itemsUpdatedCount++;
					}
				}
				for(int i = 0; i < _armorDatabase.Count; i++)
				{
					if(_armorDatabase.Get(i).Quality.IsEqual(_tempQualityOld))
					{
						itemFound = true;
						_armorDatabase.Get(i).Quality = _tempQuality;
						itemsUpdatedCount++;
					}
				}
				break;
			case MenuSelection.WeaponTypesDb:
				for(int i = 0; i < _weaponDatabase.Count; i++)
				{
					if(_weaponDatabase.Get(i).WeaponType.IsEqual(_tempWeaponTypeOld))
					{
						itemFound = true;
						_weaponDatabase.Get(i).WeaponType = _tempWeaponType;
						itemsUpdatedCount++;
					}
				}
				break;
			case MenuSelection.AttackTypesDb:
				for(int i = 0; i < _weaponDatabase.Count; i++)
				{
					if(_weaponDatabase.Get(i).AttackType.IsEqual(_tempAttackTypeOld))
					{
						itemFound = true;
						_weaponDatabase.Get(i).AttackType = _tempAttackType;
						itemsUpdatedCount++;
					}
				}
				break;
			case MenuSelection.ArmorTypesDb:
				for(int i = 0; i < _armorDatabase.Count; i++)
				{
					if(_armorDatabase.Get(i).ArmorType.IsEqual(_tempArmorTypeOld))
					{
						itemFound = true;
						_armorDatabase.Get(i).ArmorType = _tempArmorType;
						itemsUpdatedCount++;
					}
				}
				break;
			case MenuSelection.ArmorLocationsDb:
				for(int i = 0; i < _armorDatabase.Count; i++)
				{
					if(_armorDatabase.Get(i).ArmorLocation.IsEqual(_tempArmorLocationOld))
					{
						itemFound = true;
						_armorDatabase.Get(i).ArmorLocation = _tempArmorLocation;
						itemsUpdatedCount++;
					}
				}
				break;
			}
			if(itemFound)
			{
				EditorUtility.DisplayDialog("Items updated",
				                            itemsUpdatedCount.ToString() + " items were updated throughout the databases.",
				                            "Okay");
			}
			database.Replace(_selectedIndex, replacementObject);
			NullTempEntries ();
			LoadPrereqDatabaseOptions ();
			displayState = DisplayState.DisplayNothing;
			return;
		}
		
		void CancelButton (bool keepEntryDisplayed)
		{
			if(keepEntryDisplayed)
			{
				displayState = DisplayState.DisplayDatabaseEntry;
			}
			else
			{
				displayState = DisplayState.DisplayNothing;
				NullTempEntries ();
			}
		}

		void DeleteButton<T> (ScriptableObjectDatabase<T> database, MenuSelection selection, string name) where T : ISBaseObject
		{
			if((int)selection < 100)
			{
				if(EditorUtility.DisplayDialog("Delete Item",
				                               "Are you sure you want to delete " + database.Get(_selectedIndex).Name + " from the database?",
				                               "Delete",
				                               "Cancel"))
				{
					database.Remove(_selectedIndex);
					NullTempEntries();
					displayState = DisplayState.DisplayNothing;
				}
			}
			else if((int)selection < 200)
			{
				bool itemFound = SearchAllDatabasesForPrerequisiteName(name, selection);

				if(itemFound)
				{
					if(EditorUtility.DisplayDialog("Prerequisite type in use",
					                               "One or more items in the main databases is using this prerequisite type, can not delete.",
					                               "Okay"))
					{
						displayState = DisplayState.DisplayDatabaseEntry;
					}
				}
				else
				{
					database.Remove(_selectedIndex);
					NullTempEntries ();
					LoadPrereqDatabaseOptions();
					displayState = DisplayState.DisplayNothing;
				}
			}
		}

		bool SearchAllDatabasesForPrerequisiteName (string name, MenuSelection selection)
		{
			if(_weaponDatabase != null)
			{
				for(int i = 0; i < _weaponDatabase.Count; i++)
				{
					if(selection == MenuSelection.ItemQualitiesDb)
					{
						if(_weaponDatabase.Get(i).Quality.IsNameEqual(name))
						{
							 return true;
						}
					}
					else if(selection == MenuSelection.AttackTypesDb)
					{
						if(_weaponDatabase.Get(i).AttackType.IsNameEqual(name))
						{
							return true;
						}
					}
					else if(selection == MenuSelection.WeaponTypesDb)
					{
						if(_weaponDatabase.Get(i).WeaponType.IsNameEqual(name))
						{
							return true;
						}
					}
				}
			}
			if(_commonItemDatabase != null)
			{
				for(int i = 0; i < _commonItemDatabase.Count; i++)
				{
					if(selection == MenuSelection.ItemQualitiesDb)
					{
						if(_commonItemDatabase.Get(i).Quality.IsNameEqual(name))
						{
							return true;
						}
					}
				}
			}
			if(_armorDatabase != null)
			{
				for(int i = 0; i < _armorDatabase.Count; i++)
				{
					if(selection == MenuSelection.ItemQualitiesDb)
					{
						if(_armorDatabase.Get(i).Quality.IsNameEqual(name))
						{
							return true;
						}
					}
					else if(selection == MenuSelection.ArmorTypesDb)
					{
						if(_armorDatabase.Get(i).ArmorType.IsNameEqual(name))
						{
							return true;
						}
					}
					else if(selection == MenuSelection.ArmorLocationsDb)
					{
						if(_armorDatabase.Get(i).ArmorLocation.IsNameEqual(name))
						{
							return true;
						}
					}
				}
			}

			return false;
		}
	}
}