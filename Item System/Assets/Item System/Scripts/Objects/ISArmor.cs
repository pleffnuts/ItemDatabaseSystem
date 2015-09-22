using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	[System.Serializable]
	public class ISArmor : ISDestructable, IISArmor, IISGameObject
	{
		[SerializeField] GameObject			_gameObject;
		[SerializeField] int 				_armorRating;
		[SerializeField] ISArmorType		_armorType;
		[SerializeField] ISArmorLocation	_armorLocation;

		public GameObject 		Prefab			{ get { return _gameObject; } 	set { _gameObject = value; } }
		public int 				ArmorRating 	{ get { return _armorRating;  } set { _armorRating = value; } }
		public ISArmorType		ArmorType		{ get { return _armorType; }	set { _armorType = value; } }
		public ISArmorLocation	ArmorLocation	{ get { return _armorLocation; }set { _armorLocation = value; } }

		public ISArmor() : base() {}
		
		public ISArmor(ISArmor armor) : base (armor)
		{
			Clone(armor);
		}
		
		public void Clone(ISArmor armor)
		{
			_armorRating	= armor.ArmorRating;
			_gameObject 	= armor.Prefab;
			_armorType 		= armor.ArmorType;
			_armorLocation  = armor.ArmorLocation;
		}

	}
}