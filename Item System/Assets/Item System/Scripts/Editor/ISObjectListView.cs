using UnityEngine;
using UnityEditor;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void ListViewPane()
		{
			if(displayState  == DisplayState.EditDatabaseEntry 		|| displayState  == DisplayState.DisplayOther  || displayState  == DisplayState.CreateDatabaseEntry ||
			   menuSelection == MenuSelection.AboutScreen 			|| menuSelection == MenuSelection.SearchScreen ||
			   menuSelection == MenuSelection.RemoveDatabaseScreen 	|| menuSelection == MenuSelection.HelpScreen)
			{
				return;
			}

			_scrollPosition = GUILayout.BeginScrollView (_scrollPosition, "Box", GUILayout.ExpandHeight (true), GUILayout.Width(_listViewWidth));

			switch(menuSelection)
			{
			case MenuSelection.WeaponsDb:
				ListWeapons();
				break;
			case MenuSelection.ArmorDb:
				ListArmor();
				break;
			case MenuSelection.PotionsDb:
				ListPotions();
				break;
			case MenuSelection.ScrollsDb:
				ListScrolls();
				break;
			case MenuSelection.BooksDb:
				ListBooks();
				break;
			case MenuSelection.CommonItemDb:
				ListCommonItems();
				break;
			case MenuSelection.CraftMatsDb:
				ListCraftMats();
				break;
			case MenuSelection.CharacterClassDb:
				ListCharacterClasses();
				break;
			case MenuSelection.CharacterStatsDb:
				ListCharacterStats();
				break;
			case MenuSelection.ArmorTypesDb:
				ListArmorTypes();
				break;
			case MenuSelection.ArmorLocationsDb:
				ListArmorLocations();
				break;
			case MenuSelection.WeaponTypesDb:
				ListWeaponsTypes();
				break;
			case MenuSelection.AttackTypesDb:
				ListAttackTypes();
				break;
			case MenuSelection.ItemQualitiesDb:
				ListItemQualities();
				break;
			}

			GUILayout.EndScrollView ();
		}

		void ListCommonItems()
		{
			for(int i = 0; i < _commonItemDatabase.Count; i++)
			{
				if(GUILayout.Button(_commonItemDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
				{
					_selectedIndex = i;
					_tempItem  = new ISObject(_commonItemDatabase.Get(i));
					displayState = DisplayState.DisplayDatabaseEntry;
				}
			}
		}
		
		void ListWeapons()
		{
			for(int i = 0; i < _weaponDatabase.Count; i++)
			{
				if(GUILayout.Button(_weaponDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
				{
					_selectedIndex = i;
					_tempWeapon  = new ISWeapon(_weaponDatabase.Get(i));
					displayState = DisplayState.DisplayDatabaseEntry;
				}
			}
		}
	
		void ListArmor()
		{
			for(int i = 0; i < _armorDatabase.Count; i++)
			{
				if(GUILayout.Button(_armorDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
				{
					_selectedIndex = i;
					_tempArmor   = new ISArmor(_armorDatabase.Get(i));
					displayState = DisplayState.DisplayDatabaseEntry;
				}
			}
		}
	
		void ListPotions()
		{
//			for(int i = 0; i < _weaponDatabase.Count; i++)
//			{
//				if(GUILayout.Button(_weaponDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
//				{
//					_selectedIndex = i;
//					_tempWeapon  = new ISWeapon(_weaponDatabase.Get(i));
//					displayState = DisplayState.DisplayDatabaseEntry;
//				}
//			}
		}
	
		void ListScrolls()
		{
//			for(int i = 0; i < _weaponDatabase.Count; i++)
//			{
//				if(GUILayout.Button(_weaponDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
//				{
//					_selectedIndex = i;
//					_tempWeapon  = new ISWeapon(_weaponDatabase.Get(i));
//					displayState = DisplayState.DisplayDatabaseEntry;
//				}
//			}
		}
	
		void ListBooks()
		{
//			for(int i = 0; i < _weaponDatabase.Count; i++)
//			{
//				if(GUILayout.Button(_weaponDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
//				{
//					_selectedIndex = i;
//					_tempWeapon  = new ISWeapon(_weaponDatabase.Get(i));
//					displayState = DisplayState.DisplayDatabaseEntry;
//				}
//			}
		}
	
		void ListCraftMats()
		{
//			for(int i = 0; i < _weaponDatabase.Count; i++)
//			{
//				if(GUILayout.Button(_weaponDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
//				{
//					_selectedIndex = i;
//					_tempWeapon  = new ISWeapon(_weaponDatabase.Get(i));
//					displayState = DisplayState.DisplayDatabaseEntry;
//				}
//			}
		}
	
		void ListCharacterClasses()
		{
//			for(int i = 0; i < _weaponDatabase.Count; i++)
//			{
//				if(GUILayout.Button(_weaponDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
//				{
//					_selectedIndex = i;
//					_tempWeapon  = new ISWeapon(_weaponDatabase.Get(i));
//					displayState = DisplayState.DisplayDatabaseEntry;
//				}
//			}
		}
	
		void ListCharacterStats()
		{
//			for(int i = 0; i < _weaponDatabase.Count; i++)
//			{
//				if(GUILayout.Button(_weaponDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
//				{
//					_selectedIndex = i;
//					_tempWeapon  = new ISWeapon(_weaponDatabase.Get(i));
//					displayState = DisplayState.DisplayDatabaseEntry;
//				}
//			}
		}
	
		void ListArmorTypes()
		{
			for(int i = 0; i < _armorTypeDatabase.Count; i++)
			{
				if(GUILayout.Button(_armorTypeDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
				{
					_selectedIndex = i;
					_tempArmorType  = new ISArmorType(_armorTypeDatabase.Get(i));
					displayState = DisplayState.DisplayDatabaseEntry;
				}
			}
		}

		void ListArmorLocations ()
		{
			for(int i = 0; i < _armorLocationDatabase.Count; i++)
			{
				if(GUILayout.Button(_armorLocationDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
				{
					_selectedIndex = i;
					_tempArmorLocation  = new ISArmorLocation(_armorLocationDatabase.Get(i));
					displayState = DisplayState.DisplayDatabaseEntry;
				}
			}
		}
	
		void ListWeaponsTypes()
		{
			for(int i = 0; i < _weaponTypeDatabase.Count; i++)
			{
				if(GUILayout.Button(_weaponTypeDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
				{
					_selectedIndex = i;
					_tempWeaponType  = new ISWeaponType(_weaponTypeDatabase.Get(i));
					displayState = DisplayState.DisplayDatabaseEntry;
				}
			}
		}	

		void ListAttackTypes ()
		{
			for(int i = 0; i < _attackTypeDatabase.Count; i++)
			{
				if(GUILayout.Button(_attackTypeDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
				{
					_selectedIndex = i;
					_tempAttackType  = new ISAttackType(_attackTypeDatabase.Get(i));
					displayState = DisplayState.DisplayDatabaseEntry;
				}
			}
		}

		void ListItemQualities ()
		{
			for(int i = 0; i < _qualityDatabase.Count; i++)
			{
				if(GUILayout.Button(_qualityDatabase.Get(i).Name, GUILayout.Width(_listViewButtonWidth), GUILayout.Height(_listViewButtonHeight)))
				{
					_selectedIndex = i;
					_tempQuality  = new ISQuality(_qualityDatabase.Get(i));
					displayState = DisplayState.DisplayDatabaseEntry;
				}
			}
		}
	}
}