using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void ViewAttackType()
		{
			EditorGUILayout.LabelField("Attack Type Name", _tempAttackType.Name);
		}
		
		void EditAttackType()
		{
			if(!_isAttackTypeOldUpdated)
			{
				_tempAttackTypeOld = new ISAttackType (_tempAttackType);
				_isAttackTypeOldUpdated = true;
			}
			
			_tempAttackType.Name = EditorGUILayout.TextField("Attack Type Name", _tempAttackType.Name);
		}
	}
}