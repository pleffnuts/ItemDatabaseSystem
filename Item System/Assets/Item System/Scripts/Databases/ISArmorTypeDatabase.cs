using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public class ISArmorTypeDatabase : ScriptableObjectDatabase<ISArmorType> 
	{
		public int GetIndex(string name)
		{
			return database.FindIndex (a => a.Name == name);
		}
	}
}