using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	[System.Serializable]
	public class ISObject : ISBaseObject, IISObject
	{
		[SerializeField] int 		_value;
		[SerializeField] Sprite		_inventorySprite;
		[SerializeField] int 		_weight;
		[SerializeField] ISQuality	_quality;
		[SerializeField] int		_level;
		[SerializeField] bool		_stackable;

		public int 			Value 			{ get { return _value; } 			set { _value = value; } }
		public Sprite 		InventorySprite	{ get { return _inventorySprite; } 	set { _inventorySprite = value; } }
		public int 			Weight 			{ get { return _weight; }			set { _weight = value; } }
		public ISQuality 	Quality 		{ get { return _quality; } 			set { _quality = value; } }
		public int 			Level 			{ get { return _level; } 			set { _level = value; }	}
		public bool			Stackable		{ get { return _stackable; } 		set { _stackable = value; } }

		public ISObject() : base() {}

		public ISObject(ISObject item) : base(item)
		{
			Clone (item);
		}

		public void Clone(ISObject item)
		{
			_value = item.Value;
			_inventorySprite = item.InventorySprite;
			_weight = item.Weight;
			_quality = item.Quality;
			_level = item.Level;
			_stackable = item.Stackable;
		}
	}
}