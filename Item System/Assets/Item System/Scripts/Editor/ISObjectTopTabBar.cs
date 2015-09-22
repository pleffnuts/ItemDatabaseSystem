using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void TopMenuBar()
		{
			if(displayState != DisplayState.EditDatabaseEntry)
			{
				GUILayout.BeginHorizontal ("Box", GUILayout.ExpandWidth (true));

				MainItemDatabasesMenu ();
				PrerequisiteDatabasesMenu ();
				OtherMenuItems ();
				AboutMenu ();

				GUILayout.EndHorizontal ();
			}
		}

		void MainItemDatabasesMenu()
		{
			if(GUILayout.Button ("Main Databases", EditorStyles.toolbarDropDown))
			{
				GenericMenu menu = new GenericMenu ();

				menu.AddItem(new GUIContent("Common Items Database"), false, delegate(){
					displayState = DisplayState.DisplayNothing;
					menuSelection = MenuSelection.CommonItemDb;
				});
				menu.AddItem(new GUIContent("Weapon Database"), false, delegate(){
					displayState = DisplayState.DisplayNothing;
					menuSelection = MenuSelection.WeaponsDb;
				});
				menu.AddItem(new GUIContent("Armor Database"), false, delegate(){
					displayState = DisplayState.DisplayNothing;
					menuSelection = MenuSelection.ArmorDb;
				});
//				menu.AddItem(new GUIContent("Potions Database"), false, delegate(){
//					displayState = DisplayState.DisplayNothing;
//					menuSelection = MenuSelection.PotionsDb;
//				});
//				menu.AddItem(new GUIContent("Books Database"), false, delegate(){
//					displayState = DisplayState.DisplayNothing;
//					menuSelection = MenuSelection.BooksDb;
//				});
//				menu.AddItem(new GUIContent("Scrolls Database"), false, delegate(){
//					displayState = DisplayState.DisplayNothing;
//					menuSelection = MenuSelection.ScrollsDb;
//				});
//				menu.AddItem(new GUIContent("Craft Materials Database"), false, delegate(){
//					displayState = DisplayState.DisplayNothing;
//					menuSelection = MenuSelection.CraftMatsDb;
//				});

				menu.ShowAsContext ();
			}
		}

		void PrerequisiteDatabasesMenu()
		{
			if(GUILayout.Button ("Prerequisites", EditorStyles.toolbarDropDown))
			{
				GenericMenu menu = new GenericMenu ();
				
//				menu.AddItem(new GUIContent("Character Classes"), false, delegate(){
//					displayState = DisplayState.DisplayNothing;
//					menuSelection = MenuSelection.CharacterClassDb;
//				});
//				menu.AddItem(new GUIContent("Character Stats"), false, delegate(){
//					displayState = DisplayState.DisplayNothing;
//					menuSelection = MenuSelection.CharacterStatsDb;
//				});
				menu.AddItem(new GUIContent("Item Qualities"), false, delegate(){
					displayState = DisplayState.DisplayNothing;
					menuSelection = MenuSelection.ItemQualitiesDb;
				});
				menu.AddItem(new GUIContent("Weapon Types"), false, delegate(){
					displayState = DisplayState.DisplayNothing;
					menuSelection = MenuSelection.WeaponTypesDb;
				});
				menu.AddItem(new GUIContent("Attack Types"), false, delegate(){
					displayState = DisplayState.DisplayNothing;
					menuSelection = MenuSelection.AttackTypesDb;
				});
				menu.AddItem(new GUIContent("Armor Types"), false, delegate(){
					displayState = DisplayState.DisplayNothing;
					menuSelection = MenuSelection.ArmorTypesDb;
				});
				menu.AddItem(new GUIContent("Armor Locations"), false, delegate(){
					displayState = DisplayState.DisplayNothing;
					menuSelection = MenuSelection.ArmorLocationsDb;
				});

				menu.ShowAsContext ();
			}
		}

		void OtherMenuItems()
		{
			if(GUILayout.Button ("Other Tools", EditorStyles.toolbarDropDown))
			{
				GenericMenu menu = new GenericMenu ();
				
//				menu.AddItem(new GUIContent("Search"), false, delegate(){
//					displayState = DisplayState.DisplayOther;
//					menuSelection = MenuSelection.SearchScreen;
//				});
				menu.AddItem(new GUIContent("Help"), false, delegate(){
					displayState = DisplayState.DisplayOther;
					menuSelection = MenuSelection.HelpScreen;
				});
//				menu.AddItem(new GUIContent("Remove Databases"), false, delegate(){
//					displayState = DisplayState.DisplayOther;
//					menuSelection = MenuSelection.RemoveDatabaseScreen;
//				});

				menu.ShowAsContext ();
			}
		}

		void AboutMenu()
		{
			if(GUILayout.Button ("About", EditorStyles.toolbarDropDown))
			{
				displayState = DisplayState.DisplayOther;
				menuSelection = MenuSelection.AboutScreen;
			}
		}
	}
}