using UnityEditor;
using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem.Editor
{
	public partial class ISObjectEditor
	{
		void LoadPrereqDatabaseOptions()
		{
			LoadQualityDatabaseOptions ();
			LoadWeaponTypeDatabaseOptions ();
			LoadArmorTypeDatabaseOptions ();
			LoadArmorLocationDatabaseOptions ();
			LoadAttackTypeDatabaseOptions ();
		}

		void LoadQualityDatabaseOptions()
		{
			if(_qualityDatabase.Count > 0)
			{
				_qualityOptions = new string[_qualityDatabase.Count];
				
				for(int i = 0; i < _qualityDatabase.Count; i++)
				{
					_qualityOptions[i] = _qualityDatabase.Get(i).Name;
				}
				
				_qualityOptionsLoaded = true;
			}
			else
			{
				_qualityOptionsLoaded = false;
			}
		}

		bool IsQualityOptionsLoaded()
		{
			if (!_qualityOptionsLoaded)
			{
				EditorUtility.DisplayDialog ("No quality Options defined", 
				                            "Must define item quality options in the prerequisite options first before continuing.",
				                            "Okay");
				return false;
			}
			return true;
		}

		void LoadWeaponTypeDatabaseOptions()
		{
			if(_weaponTypeDatabase.Count > 0)
			{
				_weaponTypeOptions = new string[_weaponTypeDatabase.Count];
				
				for(int i = 0; i < _weaponTypeDatabase.Count; i++)
				{
					_weaponTypeOptions[i] = _weaponTypeDatabase.Get(i).Name;
				}
				
				_weaponTypeOptionsLoaded = true;
			}
			else
			{
				_weaponTypeOptionsLoaded = false;
			}
		}

		bool IsWeaponTypeOptionsLoaded()
		{
			if (!_weaponTypeOptionsLoaded)
			{
				EditorUtility.DisplayDialog ("No weapon types defined", 
				                             "Must define item weapon type options in the prerequisite options before continuing.",
				                             "Okay");
				return false;
			}
			return true;
		}
		
		void LoadAttackTypeDatabaseOptions()
		{
			if(_attackTypeDatabase.Count > 0)
			{
				_attackTypeOptions = new string[_attackTypeDatabase.Count];
				
				for(int i = 0; i < _attackTypeDatabase.Count; i++)
				{
					_attackTypeOptions[i] = _attackTypeDatabase.Get(i).Name;
				}
				
				_attackTypeOptionsLoaded = true;
			}
			else
			{
				_attackTypeOptionsLoaded = false;
			}
		}

		bool IsAttackTypeOptionsLoaded()
		{
			if(!_attackTypeOptionsLoaded)
			{
				EditorUtility.DisplayDialog("No attack types defined",
				                            "Must define attack type options in the prerequisite options before creating a weapon.",
				                            "Okay");
				return false;
			}
			return true;
		}

		void LoadArmorTypeDatabaseOptions()
		{
			if(_armorTypeDatabase.Count > 0)
			{
				_armorTypeOptions = new string[_armorTypeDatabase.Count];
				
				for(int i = 0; i < _armorTypeDatabase.Count; i++)
				{
					_armorTypeOptions[i] = _armorTypeDatabase.Get(i).Name;
				}
				
				_armorTypeOptionsLoaded = true;
			}
			else
			{
				_armorTypeOptionsLoaded = false;
			}
		}
		
		bool IsArmorTypeOptionsLoaded()
		{
			if(!_armorTypeOptionsLoaded)
			{
				EditorUtility.DisplayDialog("No armor types defined",
				                            "Must define armor type options in the prerequisite options before creating an armor.",
				                            "Okay");
				return false;
			}
			return true;
		}

		void LoadArmorLocationDatabaseOptions ()
		{
			if(_armorLocationDatabase.Count > 0)
			{
				_armorLocationOptions = new string[_armorLocationDatabase.Count];
				
				for(int i = 0; i < _armorLocationDatabase.Count; i++)
				{
					_armorLocationOptions[i] = _armorLocationDatabase.Get(i).Name;
				}
				
				_armorLocationOptionsLoaded = true;
			}
			else
			{
				_armorLocationOptionsLoaded = false;
			}
		}
		
		bool IsArmorLocationOptionsLoaded()
		{
			if(!_armorLocationOptionsLoaded)
			{
				EditorUtility.DisplayDialog("No armor locations defined",
				                            "Must define armor location options in the prerequisite options before creating an armor.",
				                            "Okay");
				return false;
			}
			return true;
		}

		void DisplayItemQuality(bool isModifiable, ISObject tempItem)
		{
			if(!_qualityOptionsLoaded && isModifiable)
			{
				return;
			}
			
			int itemIndex = 0;
			
			if(tempItem.Quality != null)
			{
				itemIndex = _qualityDatabase.GetIndex(tempItem.Quality.Name);
			}
			
			if(itemIndex == -1)
			{
				itemIndex = 0;
			}

			if(isModifiable)
			{
				_qualitySelectedIndex = EditorGUILayout.Popup ("Quality", itemIndex, _qualityOptions);
				tempItem.Quality = _qualityDatabase.Get (_qualitySelectedIndex);
			}
			else
			{
				EditorGUILayout.LabelField("Quality", tempItem.Quality.Name);
			}
		}

		void DisplayWeaponType(bool isModifiable, ISWeapon tempWeapon)
		{
			if(!_weaponTypeOptionsLoaded && isModifiable)
			{
				return;
			}
			
			int itemIndex = 0;
			
			if(tempWeapon.WeaponType != null)
			{
				itemIndex = _weaponTypeDatabase.GetIndex(tempWeapon.WeaponType.Name);
			}
			
			if(itemIndex == -1)
			{
				itemIndex = 0;
			}
			
			if(isModifiable)
			{
				_weaponTypeSelectedIndex = EditorGUILayout.Popup ("Weapon Type", itemIndex, _weaponTypeOptions);
				tempWeapon.WeaponType = _weaponTypeDatabase.Get (_weaponTypeSelectedIndex);
			}
			else
			{
				EditorGUILayout.LabelField("Weapon Type", tempWeapon.WeaponType.Name);
			}
		}

		string DisplayAttackType(bool isModifiable, ISWeapon tempWeapon)
		{
			string returnString = "";

			if(!_attackTypeOptionsLoaded && isModifiable)
			{
				return null;
			}
			
			int itemIndex = 0;
			
			if(tempWeapon.AttackType != null)
			{
				itemIndex = _attackTypeDatabase.GetIndex(tempWeapon.AttackType.Name);
			}
			
			if(itemIndex == -1)
			{
				itemIndex = 0;
			}
			
			if(isModifiable)
			{
				_attackTypeSelectedIndex = EditorGUILayout.Popup ("Attack Type", itemIndex, _attackTypeOptions);
				tempWeapon.AttackType = _attackTypeDatabase.Get (_attackTypeSelectedIndex);
			}
			else
			{
				returnString = tempWeapon.AttackType.Name.ToString();
			}

			return returnString;
		}

		void DisplayArmorType(bool isModifiable, ISArmor tempArmor)
		{
			string returnString = "";
			
			if(!_armorTypeOptionsLoaded && isModifiable)
			{
				return;
			}

			int itemIndex = 0;
			
			if(tempArmor.ArmorType != null)
			{
				itemIndex = _armorTypeDatabase.GetIndex(tempArmor.ArmorType.Name);
			}
			
			if(itemIndex == -1)
			{
				itemIndex = 0;
			}
			
			if(isModifiable)
			{
				_armorTypeSelectedIndex = EditorGUILayout.Popup ("Armor Type", itemIndex, _armorTypeOptions);
				tempArmor.ArmorType = _armorTypeDatabase.Get (_armorTypeSelectedIndex);
			}
			else
			{
				EditorGUILayout.LabelField("Armor Type", tempArmor.ArmorType.Name);
			}
		}
	
		void DisplayArmorLocation(bool isModifiable, ISArmor tempArmor)
		{
			string returnString = "";
			
			if(!_armorLocationOptionsLoaded && isModifiable)
			{
				return;
			}
			
			int itemIndex = 0;
			
			if(tempArmor.ArmorLocation != null)
			{
				itemIndex = _armorLocationDatabase.GetIndex(tempArmor.ArmorLocation.Name);
			}
			
			if(itemIndex == -1)
			{
				itemIndex = 0;
			}
			
			if(isModifiable)
			{
				_armorLocationSelectedIndex = EditorGUILayout.Popup ("Armor Location", itemIndex, _armorLocationOptions);
				tempArmor.ArmorLocation = _armorLocationDatabase.Get (_armorLocationSelectedIndex);
			}
			else
			{
				EditorGUILayout.LabelField("Armor Location", tempArmor.ArmorLocation.Name);
			}
		}
	}
}