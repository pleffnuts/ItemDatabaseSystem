using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	[System.Serializable]
	public class ISBaseObject : IISBaseObject
	{
		[SerializeField] string 	_name;
		
		public string Name { get { return _name; } set { _name = value; } }
		
		public ISBaseObject()
		{
			_name = "";
		}
		
		public ISBaseObject(ISBaseObject copiedObject)
		{
			Clone(copiedObject);
		}
		
		public void Clone(ISBaseObject copiedObject)
		{
			_name = copiedObject.Name;
		}
		
		public bool IsEqual(ISBaseObject otherObject)
		{
			return (_name == otherObject.Name);
		}

		public bool IsNameEqual(string name)
		{
			return (_name == name);
		}

	}
}