namespace Interfaces.Serealization
{
	
	/// <summary>
	/// Data what need to save
	/// </summary>
	public interface ISavedData
	{
 
		/// <summary>
		/// Saving data of statistics
		/// </summary>
		PlayerStatisticSavedData PlayerStatisticSavedData { get; set; }

 
	}
}
