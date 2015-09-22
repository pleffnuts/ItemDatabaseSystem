using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void ViewArmorType()
		{
			EditorGUILayout.LabelField("Armor Type Name", _tempArmorType.Name);
		}
		
		void EditArmorType()
		{
			if(!_isArmorTypeOldUpdated)
			{
				_tempArmorTypeOld = new ISArmorType (_tempArmorType);
				_isArmorTypeOldUpdated = true;
			}
			
			_tempArmorType.Name = EditorGUILayout.TextField("Armor Type Name", _tempArmorType.Name);
		}
	}
}