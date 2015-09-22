using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public class ISAttackTypeDatabase : ScriptableObjectDatabase<ISAttackType> 
	{
		public int GetIndex(string name)
		{
			return database.FindIndex (a => a.Name == name);
		}
	}
}
