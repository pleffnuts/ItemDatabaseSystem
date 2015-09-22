using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public class ISQualityDatabase : ScriptableObjectDatabase<ISQuality>
	{
		public int GetIndex(string name)
		{
			return database.FindIndex (a => a.Name == name);
		}
	}
}