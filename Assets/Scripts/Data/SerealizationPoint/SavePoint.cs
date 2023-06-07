using UnityEngine;

namespace Data.SerealizationPoint
{
	/// <summary>
	/// Contains serializables for save. Can save session.
	/// </summary>
	public class SavePoint : SerializationPoint
	{
		/// <summary>
		/// Call save session, when enable
		/// </summary>
		[SerializeField] private bool saveWhenEnable = false;

		/// <summary>
		/// Call save session, when disable
		/// </summary>
		[SerializeField] private bool saveWhenDisable = false;

		private void Awake()
		{
			GameSaver.Instance.SavePoint = this;
		}

		private void OnEnable()
		{
			if (saveWhenEnable)
				GameSaver.Instance.SaveSession();
		}

		private void OnDisable()
		{
			if (saveWhenDisable)
				GameSaver.Instance.SaveSession();
		}
	}
}
