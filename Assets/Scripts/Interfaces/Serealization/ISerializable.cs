namespace Interfaces.Serealization
{
	public interface ISerializable
	{
		/// <summary>
		/// Set data to the SaveData structure
		/// </summary>
		void Save(ISavedData saveData);

		/// <summary>
		/// Get data to the SaveData structure
		/// </summary>
		void Load(ISavedData saveData);

	}
}