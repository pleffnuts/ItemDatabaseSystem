using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public interface IISObject
	{
		int 		Value 			{ get; set; }
		Sprite		InventorySprite { get; set; }
		int 		Weight 			{ get; set; }
		ISQuality	Quality			{ get; set; }
		int			Level			{ get; set; }
		bool		Stackable		{ get; set; }
	}
}