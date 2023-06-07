namespace Data.Profile
{
	/// <summary>
	/// Profile that contains all base infomation about users
	/// </summary>
	public interface IProfile
	{
		/// <summary>
		/// Unique identifire of user at server
		/// </summary>
		string Id { get; }
		string URL { get; }

	}
}