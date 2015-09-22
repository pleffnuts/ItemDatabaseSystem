using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{	
		void ViewArmor()
		{
			ViewArmor (_tempArmor);
		}
		
		void EditArmor()
		{
			EditArmor (_tempArmor);
		}
		
		void ViewArmor(ISArmor tempArmor)
		{
			ViewCommonItem (tempArmor);

			EditorGUILayout.LabelField("Max Durability", tempArmor.MaxDurability.ToString());
			EditorGUILayout.LabelField("Armor Rating", tempArmor.ArmorRating.ToString());

			DisplayArmorType (false, tempArmor);
			DisplayArmorLocation (false, tempArmor);

			if(_tempArmor.Prefab == null)
			{
				EditorGUILayout.LabelField ("Prefab", "Empty");
			}
			else
			{
				EditorGUILayout.LabelField ("Prefab", tempArmor.Prefab.name);
			}
		}
		
		void EditArmor(ISArmor tempArmor)
		{
			EditCommonItem (tempArmor);
			
			tempArmor.ArmorRating 	= EditorGUILayout.IntField("Armor Rating", tempArmor.ArmorRating);
			if(tempArmor.ArmorRating < 0) tempArmor.ArmorRating = 0;
			
			tempArmor.MaxDurability = EditorGUILayout.IntField("Max Durability", tempArmor.MaxDurability);
			if(tempArmor.MaxDurability < 1) tempArmor.MaxDurability = 1;
			
			DisplayArmorType (true, tempArmor);
			DisplayArmorLocation (true, tempArmor);

			tempArmor.Prefab 		= EditorGUILayout.ObjectField ("Prefab", tempArmor.Prefab, typeof(GameObject), false) as GameObject;
		}
		
		bool IsArmorFormComplete(ISArmor tempArmor)
		{
			IsItemFormComplete (tempArmor);
			if(tempArmor.InventorySprite == null)
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