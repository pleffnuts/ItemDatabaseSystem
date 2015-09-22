using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public class ISArmorLocationDatabase : ScriptableObjectDatabase<ISArmorLocation> 
	{
		public int GetIndex(string name)
		{
			return database.FindIndex (a => a.Name == name);
		}
	}
}