using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{	
		void ViewWeapon()
		{
			ViewWeapon (_tempWeapon);
		}
		
		void EditWeapon()
		{
			EditWeapon (_tempWeapon);
		}

		void ViewWeapon(ISWeapon tempWeapon)
		{
			ViewCommonItem (tempWeapon);
			EditorGUILayout.LabelField("Min Damage", tempWeapon.MinDamage.ToString());
			EditorGUILayout.LabelField("Max Damage", tempWeapon.MaxDamage.ToString());
			EditorGUILayout.LabelField("Max Durability", tempWeapon.MaxDurability.ToString());

			DisplayWeaponType (false, tempWeapon);

			GUILayout.BeginHorizontal ();
			if(tempWeapon.TwoHanded)
			{
				EditorGUILayout.LabelField("Attack type", "Two-handed " + DisplayAttackType (false, tempWeapon));
			}
			else
			{
				EditorGUILayout.LabelField("Attack type", "One-handed " + DisplayAttackType (false, tempWeapon));
			}
			GUILayout.EndHorizontal ();

			if(_tempWeapon.Ranged)
			{
				EditorGUILayout.LabelField("Range", tempWeapon.Range.ToString());
			}

			if(_tempWeapon.Prefab == null)
			{
				EditorGUILayout.LabelField ("Prefab", "Empty");
			}
			else
			{
				EditorGUILayout.LabelField ("Prefab", tempWeapon.Prefab.name);
			}
		}
		
		void EditWeapon(ISWeapon tempWeapon)
		{
			EditCommonItem (tempWeapon);

			tempWeapon.MinDamage 		= EditorGUILayout.IntField("Min Damage", tempWeapon.MinDamage);
			if(tempWeapon.MinDamage < 0) tempWeapon.MinDamage = 0;

			tempWeapon.MaxDamage 		= EditorGUILayout.IntField("Max Damage", tempWeapon.MaxDamage);
			if(tempWeapon.MaxDamage < 0) tempWeapon.MaxDamage = 0;

			tempWeapon.MaxDurability 	= EditorGUILayout.IntField("Max Durability", tempWeapon.MaxDurability);
			if(tempWeapon.MaxDurability < 1) tempWeapon.MaxDurability = 1;

			DisplayWeaponType (true, tempWeapon);
			DisplayAttackType (true, tempWeapon);

			tempWeapon.TwoHanded		= EditorGUILayout.Toggle("Two-Handed weapon?", tempWeapon.TwoHanded);
			tempWeapon.Ranged			= EditorGUILayout.Toggle("Ranged weapon?", tempWeapon.Ranged);

			if(tempWeapon.Ranged)
			{
				tempWeapon.Range 		= EditorGUILayout.IntField("Range", tempWeapon.Range);
				if(tempWeapon.Range < 1) tempWeapon.Range = 1;
			}

			tempWeapon.Prefab 			= EditorGUILayout.ObjectField ("Prefab", tempWeapon.Prefab, typeof(GameObject), false) as GameObject;
		}

		bool IsWeaponFormComplete(ISWeapon tempWeapon)
		{
			IsItemFormComplete (tempWeapon);
			if(tempWeapon.InventorySprite == null)
			{
				EditorUtility.DisplayDialog("Weapon not given an inventory sprite",
				                            "You must give the weapon an inventory sprite before saving.",
				                            "Okay");
				return false;
			}

			return true;
		}
	}
}