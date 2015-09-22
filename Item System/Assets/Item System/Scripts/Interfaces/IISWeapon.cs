using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public interface IISWeapon
	{
		int 			MinDamage 	{ get; set; }
		int 			MaxDamage 	{ get; set; }
		ISWeaponType	WeaponType 	{ get; set; }
		ISAttackType	AttackType	{ get; set; }
		bool			TwoHanded	{ get; set; }
		bool			Ranged		{ get; set; }
		int				Range		{ get; set; }

		int Attack();
	}
}