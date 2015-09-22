using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public class ISCharacterStat : ISBaseObject
	{
		[SerializeField]string 	_name;

		public ISCharacterStat()
		{
			_name = "";
		}
		
		public string CharacterStatName { get{ return _name; } set{ _name = value; } }
	}
}