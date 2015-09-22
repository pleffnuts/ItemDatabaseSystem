using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void ViewWeaponType()
		{
			EditorGUILayout.LabelField("Weapon Type Name", _tempWeaponType.Name);
		}
		
		void EditWeaponType()
		{
			if(!_isWeaponTypeOldUpdated)
			{
				_tempWeaponTypeOld = new ISWeaponType (_tempWeaponType);
				_isWeaponTypeOldUpdated = true;
			}
			
			_tempWeaponType.Name = EditorGUILayout.TextField("Weapon Type Name", _tempWeaponType.Name);
		}
	}
}