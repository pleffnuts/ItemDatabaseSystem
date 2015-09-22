using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void ViewHelpScreen()
		{
			GUILayout.Label ("");
			GUILayout.Label ("");
			
			GUILayout.Label ("There are two types of lists generated using this system: Item Databases (Main Databases Tab) and Prerequisite Lists (Prerequisites Tab).");
			GUILayout.Label ("");
			GUILayout.Label ("Prerequisite Lists are required to be populated first to enable the creation of items in the main databases.");
			GUILayout.Label ("All items, regardless of database require Item Qualities (e.g. common, uncommon, rare, etc).");
			GUILayout.Label ("Weapons require that weapon types (sword, mace, etc) and attack types (slashing, piercing, etc.) be defined. ");
			GUILayout.Label ("Armor requires that armor types (leather, chain, plate, etc) and armor locations (head, shoulders, chest, etc.) be defined.");

			GUILayout.Label ("");
			GUILayout.Label ("Other considerations:");
			GUILayout.Label ("You can not delete a prerequisite list item in use by an item in the main databases.");
			GUILayout.Label ("Modifying a prerequisite list item in use will force updates to all main database items that use the prerequisite list item.");
			GUILayout.Label ("Two items of the same name in any list or database is not allowed.");
			GUILayout.Label ("If you want to change the name of an item already created then select the item and use 'copy'. Delete the old item afterwards.");
		}
	}
}