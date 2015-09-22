using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public class ISCharacterClass : ISBaseObject
	{
		[SerializeField]string 	_name;
		
		public ISCharacterClass()
		{
			_name = "";
		}
		
		public string CharacterClassName { get{ return _name; } set{ _name = value; } }
	}
}
