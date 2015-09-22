using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	[System.Serializable]
	public class ISArmorType : ISBaseObject
	{
		public ISArmorType() : base() {}
		
		public ISArmorType(ISArmorType copiedObject) : base(copiedObject) {}
	}
}
