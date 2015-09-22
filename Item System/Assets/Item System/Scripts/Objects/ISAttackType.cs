using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	[System.Serializable]
	public class ISAttackType : ISBaseObject
	{
		public ISAttackType() : base() {}
		
		public ISAttackType(ISAttackType copiedObject) : base(copiedObject) {}
	}
}
