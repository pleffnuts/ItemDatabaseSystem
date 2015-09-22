using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void BottomStatusBar()
		{
			GUILayout.BeginHorizontal ("Box", GUILayout.ExpandWidth (true));

			switch(menuSelection)
			{
			case MenuSelection.WeaponsDb:
				WeaponsStatusBar();
				break;
			case MenuSelection.ArmorDb:
				ArmorStatusBar();
				break;
			case MenuSelection.PotionsDb:
				PotionsStatusBar();
				break;
			case MenuSelection.ScrollsDb:
				ScrollsStatusBar();
				break;
			case MenuSelection.BooksDb:
				BooksStatusBar();
				break;
			case MenuSelection.CommonItemDb:
				CommonItemStatusBar();
				break;
			case MenuSelection.CraftMatsDb:
				CraftMatsStatusBar();
				break;
			case MenuSelection.CharacterClassDb:
				CharacterClassStatusBar();
				break;
			case MenuSelection.CharacterStatsDb:
				CharacterStatsStatusBar();
				break;
			case MenuSelection.ArmorTypesDb:
				ArmorTypesStatusBar();
				break;
			case MenuSelection.ArmorLocationsDb:
				ArmorLocationsStatusBar();
				break;
			case MenuSelection.WeaponTypesDb:
				WeaponTypesStatusBar();
				break;
			case MenuSelection.AttackTypesDb:
				AttackTypesStatusBar();
				break;
			case MenuSelection.ItemQualitiesDb:
				ItemQualitiesStatusBar();
				break;
			}

			GUILayout.EndHorizontal ();
		}

		void CommonItemStatusBar ()
		{
			GUILayout.Label ("Common Items Database");
			GUILayout.Label ("Total Items: " + _commonItemDatabase.Count);
		}
		
		void WeaponsStatusBar ()
		{
			GUILayout.Label ("Weapons Database");
			GUILayout.Label ("Total Weapons: " + _weaponDatabase.Count);
		}

		void ArmorStatusBar ()
		{
			GUILayout.Label ("Armor Database");
			GUILayout.Label ("Total Armors: " + _armorDatabase.Count);		
		}

		void PotionsStatusBar ()
		{

		}

		void ScrollsStatusBar ()
		{

		}

		void BooksStatusBar ()
		{

		}

		void CraftMatsStatusBar ()
		{

		}

		void CharacterClassStatusBar ()
		{

		}

		void CharacterStatsStatusBar ()
		{

		}

		void ItemQualitiesStatusBar ()
		{
			GUILayout.Label ("Item Qualities");
			GUILayout.Label ("Total qualities defined: " + _qualityDatabase.Count);
		}
		
		void ArmorTypesStatusBar ()
		{
			GUILayout.Label ("Armor Types");
			GUILayout.Label ("Total armor types defined: " + _armorTypeDatabase.Count);
		}

		void ArmorLocationsStatusBar ()
		{
			GUILayout.Label ("Armor Locations");
			GUILayout.Label ("Total armor locations defined: " + _armorLocationDatabase.Count);
		}

		void WeaponTypesStatusBar ()
		{
			GUILayout.Label ("Weapon Types");
			GUILayout.Label ("Total weapon types defined: " + _weaponTypeDatabase.Count);
		}

		void AttackTypesStatusBar ()
		{
			GUILayout.Label ("Attack Types");
			GUILayout.Label ("Total attack types defined: " + _weaponTypeDatabase.Count);
		}
	}
}