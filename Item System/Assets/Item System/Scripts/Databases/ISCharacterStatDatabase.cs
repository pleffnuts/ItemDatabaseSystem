using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public class ISCharacterStatDatabase : ScriptableObjectDatabase<ISCharacterStat> 
	{
		public int GetIndex(string name)
		{
			return database.FindIndex (a => a.CharacterStatName == name);
		}
	}
}