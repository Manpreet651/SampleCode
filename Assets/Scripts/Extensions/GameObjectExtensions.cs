using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace UnityLibrary.Extensions
{
	public static class GameObjectExtensions
	{
		public static T GetGenericComponent<T>(this GameObject go) where T : class
		{
			return go.GetComponent(typeof (T)) as T;
		}

		public static T GetGenericComponentInChildren<T>(this GameObject go) where T : class
		{
			return go.GetComponentInChildren(typeof (T)) as T;
		}

		public static IEnumerable<T> GetGenericComponentsInChildren<T>(this GameObject go) where T : class
		{
			return go.GetComponentsInChildren(typeof (T)).Select(component => component as T);
		}

		public static T GetGenericComponentInParent<T>(this GameObject go) where T : class
		{
			return go.GetComponentInParent(typeof(T)) as T;
		}
	}
}
