using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void ViewItemQuality()
		{
			EditorGUILayout.LabelField("Item Quality Name", _tempQuality.Name);

			GUILayout.BeginHorizontal ();
			EditorGUILayout.ObjectField("Quality Color Shade (Sprite)", _tempQuality.Icon, typeof(Sprite), false);
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();
		}
		
		void EditItemQuality()
		{
			if(!_isQualityOldUpdated)
			{
				_tempQualityOld = new ISQuality (_tempQuality);
				_isQualityOldUpdated = true;
			}

			_tempQuality.Name 			= EditorGUILayout.TextField("Item Quality Name", _tempQuality.Name);
			
			GUILayout.BeginHorizontal ();
			_tempQuality.Icon 			= EditorGUILayout.ObjectField("Quality Color Shade (Sprite)", _tempQuality.Icon, typeof(Sprite), false) as Sprite;
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();
		}
	}
}