using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void ViewCommonItem()
		{
			ViewCommonItem (_tempItem);
		}

		void EditCommonItem()
		{
			EditCommonItem (_tempItem);
		}

		void ViewCommonItem(ISObject tempItem)
		{
			EditorGUILayout.LabelField("Name", tempItem.Name);
			EditorGUILayout.LabelField("Value", tempItem.Value.ToString());
			EditorGUILayout.LabelField("Weight", tempItem.Weight.ToString());
			EditorGUILayout.LabelField("Level", tempItem.Level.ToString());
			EditorGUILayout.LabelField("Stackable", tempItem.Stackable.ToString ());

			GUILayout.BeginHorizontal ();
			EditorGUILayout.ObjectField("Inventory Sprite", tempItem.InventorySprite, typeof(Sprite), false);
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

			DisplayItemQuality (false, tempItem);
		}

		void EditCommonItem(ISObject tempItem)
		{
			if(displayState == DisplayState.CreateDatabaseEntry)
			{

				tempItem.Name = EditorGUILayout.TextField("Name: ", tempItem.Name);
			}
			else
			{
				EditorGUILayout.LabelField("Name", tempItem.Name);
			}
			tempItem.Value 			= EditorGUILayout.IntField("Value", tempItem.Value);
			if(tempItem.Value < 0) 	tempItem.Value = 0;

			tempItem.Weight			= EditorGUILayout.IntField("Weight", tempItem.Weight);
			if(tempItem.Weight < 1) tempItem.Weight = 1;

			tempItem.Level 			= EditorGUILayout.IntField("Level", tempItem.Level);
			if(tempItem.Level < 1) tempItem.Level = 1;
			tempItem.Stackable 		= EditorGUILayout.Toggle ("Stackable", tempItem.Stackable);

			GUILayout.BeginHorizontal ();
			tempItem.InventorySprite= EditorGUILayout.ObjectField ("Inventory Sprite", tempItem.InventorySprite, typeof(Sprite), false) as Sprite;
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

			DisplayItemQuality (true, tempItem);
		}

		bool IsItemFormComplete(ISObject tempItem)
		{
			if(tempItem.InventorySprite == null)
			{
				EditorUtility.DisplayDialog("Item not given an inventory sprite",
				                            "You must give the item an inventory sprite before saving.",
				                            "Okay");
				return false;
			}
			
			return true;
		}
	}
}