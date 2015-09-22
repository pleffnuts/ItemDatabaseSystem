using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public interface IISDestructable
	{
		int 		Durability 		{ get; }
		int			MaxDurability	{ get; }

		void TakeDamage(int amountOfDamage);
		void Repair();
		void Break();
	}
}