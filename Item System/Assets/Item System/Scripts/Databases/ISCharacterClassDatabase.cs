using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public class ISCharacterClassDatabase : ScriptableObjectDatabase<ISCharacterClass>
	{
		public int GetIndex(string name)
		{
			return database.FindIndex (a => a.CharacterClassName == name);
		}
	}
}
