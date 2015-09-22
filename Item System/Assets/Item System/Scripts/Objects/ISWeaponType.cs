using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	[System.Serializable]
	public class ISWeaponType : ISBaseObject
	{
		public ISWeaponType() : base() {}
		
		public ISWeaponType(ISWeaponType copiedObject) : base(copiedObject) {}
	}
}
