using System.Collections.Generic;
using UnityEngine;
using UnityLibrary.Extensions;
using Interfaces.Serealization;

namespace Data.SerealizationPoint
{
	/// <summary>
	/// Contains serializables
	/// </summary>
	public abstract class SerializationPoint : MonoBehaviour
	{
		/// <summary>
		/// Serializables game objects
		/// </summary>
		[SerializeField] private List<GameObject> serializables = new List<GameObject>();

		public virtual IEnumerable<ISerializable> Serializables
		{
			get
			{
				serializables.RemoveAll(s => s == null);
				var list = new List<ISerializable>();
				foreach (var go in serializables)
				{
					var s = go.GetGenericComponent<ISerializable>();
					if (s != null && !list.Contains(s))
						list.Add(s);
				}
				return list;
			}
		}
	}
}