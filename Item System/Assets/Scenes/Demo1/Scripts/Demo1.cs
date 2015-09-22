using UnityEngine;
using System.Collections;
using Plefnuts.ItemSystem;

[DisallowMultipleComponent]
public class Demo1 : MonoBehaviour
{
	public ISWeaponDatabase database;

	void OnGUI()
	{
		for(int i = 0; i < database.Count; i++)
		{
			if(GUILayout.Button("Spawn: " + database.Get(i).Name))
			{
				Spawn(i);
			}
		}
	}

	void Spawn(int cnt)
	{
		Debug.Log (database.Get (cnt).Name);

		ISWeapon isw = database.Get (cnt);

		GameObject weapon = Instantiate (isw.Prefab);
		weapon.name = isw.Name;

		Weapon myWeapon = weapon.AddComponent<Weapon> ();

		myWeapon.Name = isw.Name;
		myWeapon.Icon = isw.InventorySprite;
		myWeapon.Value = isw.Value;
		myWeapon.Level = isw.Level;
		myWeapon.Weight = isw.Weight;
		myWeapon.MinDamage = isw.MinDamage;
		myWeapon.MaxDamage = isw.MaxDamage;
		myWeapon.Durability = isw.Durability;
		myWeapon.MaxDurability = isw.MaxDurability;
//		myWeapon.Equippable = isw.Equippable;
		myWeapon.QualityShade = isw.Quality;
//		myWeapon.EquipmentSlot = isw.EquipmentSlot;
	}
}
