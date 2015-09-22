using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	[System.Serializable]
	public class ISQuality : ISBaseObject
	{
		[SerializeField]Sprite	_icon;

		public Sprite Icon { get{ return _icon; } set{ _icon = value; } }

		public ISQuality() : base()
		{
			_icon = new Sprite ();
		}

		public ISQuality(ISQuality quality) : base(quality)
		{
			Clone(quality);
		}

		public ISQuality(string qualityName, Sprite sprite)
		{
			Name = qualityName;
			_icon = sprite;
		}

		public void Clone(ISQuality quality)
		{
			_icon = quality.Icon;
		}
//
//		public bool IsEqual(ISQuality quality)
//		{
//			return (Name == quality.Name && _icon == quality.Icon);
//		}
	}
}