using UnityEngine;

namespace Data.SerealizationPoint
{
	/// <summary>
	/// Contains serializables for load. Can restore session.
	/// </summary>
	public class LoadPoint : SerializationPoint
	{
		[SerializeField] private bool loadOnAwake = false;

		private void Awake()
		{
			GameSaver.Instance.LoadPoint = this;
			if (loadOnAwake)
				GameSaver.Instance.RestoreSession();
		}
	}
}
