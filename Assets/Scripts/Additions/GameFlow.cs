
using UnityLibrary.Additions;
using Data.Profile;
using Server.Data;

public class GameFlow :  Singletone<GameFlow>  {

	/// <summary>
	/// Current player profile 
	/// </summary>
	public IPlayerProfile PlayerProfile
	{
		get{  return ServerPlatform.Instance.PlayerProfile; }
	}

}
