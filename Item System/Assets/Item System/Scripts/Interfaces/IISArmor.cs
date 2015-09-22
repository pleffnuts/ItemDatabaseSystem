using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public interface IISArmor
	{
		int 			ArmorRating 	{ get; set; }
		ISArmorType		ArmorType 		{ get; set; }
		ISArmorLocation ArmorLocation	{ get; set; }
	}
}