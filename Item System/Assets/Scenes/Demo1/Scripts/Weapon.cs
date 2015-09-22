using UnityEngine;
using System.Collections;
using Plefnuts.ItemSystem;

[DisallowMultipleComponent]
public class Weapon : MonoBehaviour
{
	public string			Name;
	public Sprite 			Icon;
	public int				Value;
	public int				Level;
	public int				Weight;
	public int				MinDamage;
	public int				MaxDamage;
	public int				Durability;
	public int				MaxDurability;
	public ISQuality		QualityShade;
}
