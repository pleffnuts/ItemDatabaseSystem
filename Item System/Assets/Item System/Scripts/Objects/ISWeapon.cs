using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	[System.Serializable]
	public class ISWeapon : ISDestructable, IISWeapon, IISGameObject
	{
		[SerializeField] int 				_minDamage;
		[SerializeField] int 				_maxDamage;
		[SerializeField] ISWeaponType		_weaponType;
		[SerializeField] GameObject			_gameObject;
		[SerializeField] int				_range;
		[SerializeField] bool				_twoHanded;
		[SerializeField] bool				_ranged;
		[SerializeField] ISAttackType		_attackType;

		public int 				MinDamage 		{ get { return _minDamage;  } 	set { _minDamage = value; } }
		public int 				MaxDamage 		{ get { return _maxDamage;  } 	set { _maxDamage = value; } }
		public ISWeaponType		WeaponType		{ get { return _weaponType; }	set { _weaponType = value; } }
		public GameObject 		Prefab			{ get { return _gameObject; } 	set { _gameObject = value; } }
		public ISAttackType		AttackType		{ get { return _attackType; }	set { _attackType = value; } }
		public bool				Ranged			{ get { return _ranged;		}	set { _ranged = value; } }
		public int				Range			{ get { return _range;		}	set { _range = value; } }
		public bool				TwoHanded		{ get { return _twoHanded;	}	set { _twoHanded = value; } }

		public ISWeapon() : base() {}

		public ISWeapon(ISWeapon weapon) : base (weapon)
		{
			Clone(weapon);
		}

		public void Clone(ISWeapon weapon)
		{
			_minDamage 		= weapon.MinDamage;
			_maxDamage 		= weapon.MaxDamage;
			_weaponType 	= weapon.WeaponType;
			_gameObject 	= weapon.Prefab;
			_attackType 	= weapon.AttackType;
			_range 			= weapon.Range;
			_ranged			= weapon.Ranged;
			_twoHanded 		= weapon.TwoHanded;
		}

		/// <summary>
		/// Attack this weapon. Calculates damage done by weapon
		/// </summary>
		public int Attack ()
		{
			return 0;
		}
	}
}