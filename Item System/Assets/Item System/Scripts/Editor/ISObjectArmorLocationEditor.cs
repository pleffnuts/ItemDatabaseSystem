using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void ViewArmorLocation()
		{
			EditorGUILayout.LabelField("Armor Location Name", _tempArmorLocation.Name);
		}
		
		void EditArmorLocation()
		{
			if(!_isArmorLocationOldUpdated)
			{
				_tempArmorLocationOld = new ISArmorLocation (_tempArmorLocation);
				_isArmorLocationOldUpdated = true;
			}
			
			_tempArmorLocation.Name = EditorGUILayout.TextField("Armor Location Name", _tempArmorLocation.Name);
		}
	}
}