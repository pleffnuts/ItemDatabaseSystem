using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public class ISWeaponTypeDatabase : ScriptableObjectDatabase<ISWeaponType> 
	{
		public int GetIndex(string name)
		{
			return database.FindIndex (a => a.Name == name);
		}
	}
}
