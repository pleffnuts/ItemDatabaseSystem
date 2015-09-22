using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void ViewAboutScreen()
		{
			GUILayout.Label ("");
			GUILayout.Label ("");

			GUILayout.BeginHorizontal ();
			GUILayout.FlexibleSpace ();
			GUILayout.Label ("Comprehensive Item Database System");
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

			GUILayout.Label ("");

			GUILayout.BeginHorizontal ();
			GUILayout.FlexibleSpace ();
			GUILayout.Label ("Copyright 2015 by Brian Pleffner");
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();

			GUILayout.BeginHorizontal ();
			GUILayout.FlexibleSpace ();
			GUILayout.Label ("Based on the Item Database and Editor Code Along by Petey at BurgzergArcade");
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();
			
			GUILayout.Label ("");

			GUILayout.BeginHorizontal ();
			GUILayout.FlexibleSpace ();
			GUILayout.Label ("Version 0.1");
			GUILayout.FlexibleSpace ();
			GUILayout.EndHorizontal ();
		}
	}
}