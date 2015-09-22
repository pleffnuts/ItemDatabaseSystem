using UnityEngine;
using System.Collections;

namespace Plefnuts.ItemSystem
{
	public interface IISStackable
	{
		int MaxStack	{ get; }

		int Stack(int amount);
	}
}