using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public class ISDestructable : ISObject, IISDestructable
	{
		[SerializeField] int 				_durability;
		[SerializeField] int 				_maxDurability;

		public int 	Durability 		{ get { return _durability; }	set { _durability = value; } }
		public int 	MaxDurability 	{ get { return _maxDurability; }set { _maxDurability = value; } }

		public ISDestructable() : base() {}
		
		public ISDestructable(ISDestructable item) : base (item)
		{
			Clone (item);
		}
		
		public void Clone(ISDestructable item)
		{
			_durability = item.Durability;
			_maxDurability = item.MaxDurability;
		}

		/// <summary>
		/// The weapon takes an amount of damage to its durability.
		/// </summary>
		/// <param name="amountOfDamage">Amount of damage.</param>
		public void TakeDamage(int amountOfDamage)
		{
			_durability -= amountOfDamage;
			
			if(_durability < 0)
			{
				_durability = 0;
			}
		}
		
		/// <summary>
		/// Repair this weapon. Also reduces Max Durability by one
		/// </summary>
		public void Repair()
		{
			_maxDurability--;
			
			if(_maxDurability > 0)
			{
				_durability = _maxDurability;
			}
		}
		
		/// <summary>
		/// Break this weapon by reducing Durability to 0.
		/// </summary>
		public void Break()
		{
			_durability = 0;
		}

	}
}