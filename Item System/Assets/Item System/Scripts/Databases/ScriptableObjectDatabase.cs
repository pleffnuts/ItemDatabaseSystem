#if UNITY_EDITOR
using UnityEditor;
#endif
using UnityEngine;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace Plefnuts
{
	public class ScriptableObjectDatabase<T> : ScriptableObject where T : class
	{
		[SerializeField] protected List<T> database = new List<T>();

		public int Count
		{
			get{return database.Count;}
		}

		public T Get(int index)
		{
			return database.ElementAt(index);
		}
#if UNITY_EDITOR		
		public void Add(T itemToAdd)
		{
			database.Add (itemToAdd);
			EditorUtility.SetDirty (this);
		}
		
		public void Insert(int index, T itemToInsert)
		{
			database.Insert (index, itemToInsert);
			EditorUtility.SetDirty (this);
		}
		
		public void Remove(T itemToRemove)
		{
			database.Remove (itemToRemove);
			EditorUtility.SetDirty (this);
		}
		
		public void Remove(int index)
		{
			database.RemoveAt (index);
			EditorUtility.SetDirty (this);
		}
		
		public void Replace(int index, T itemToReplaceWith)
		{
			database [index] = itemToReplaceWith;
			EditorUtility.SetDirty (this);
		}

		public static U GetDatabase<U> (string dbPath, string dbName) where U : ScriptableObject
		{
			string dbFullPath = @"Assets/" + dbPath + "/" + dbName;

			U db = AssetDatabase.LoadAssetAtPath (dbFullPath, typeof(U)) as U;
			
			if(db == null)
			{
				if(!AssetDatabase.IsValidFolder(@"Assets/" + dbPath))
				{
					AssetDatabase.CreateFolder(@"Assets", dbPath);
				}
				
				db = ScriptableObject.CreateInstance<U>() as U;
				AssetDatabase.CreateAsset(db, dbFullPath);
				AssetDatabase.SaveAssets();
				AssetDatabase.Refresh();
			}

			return db;
		}
#endif
	}
}