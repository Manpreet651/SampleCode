using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityLibrary.Additions;
using Data.Profile;
using Interfaces.Serealization;
using Data.SerealizationPoint;

namespace Server.Data
{

	public class ServerPlatform :  Singletone<ServerPlatform>
	{

		private IPlayerProfile playerProfile = new InvalidPlayerProfile ();

		public IPlayerProfile PlayerProfile {
			get { return playerProfile; }
		}


		public void LoadUserData ()
		{
			var texture = new Texture2D((int) 10,1);
			ISavedData userData = new SavedData();

			userData.PlayerStatisticSavedData.avarageSpeed = 10;
			userData.PlayerStatisticSavedData.maxSpeed = 20;
			userData.PlayerStatisticSavedData.totalDistance = 15;
			userData.PlayerStatisticSavedData.totalTime = 1500;



			IPlayerProfile _PlayerProfile = null;
			_PlayerProfile = new PlayerProfile ("tempid", "TempName", texture, "tempUrl");
			_PlayerProfile.SavedData = userData;

			this.playerProfile = _PlayerProfile;

			GameSaver.Instance.RestoreSession ();
		}

		public void SaveUserData ()
		{
	
			 


//			IPlayerProfile PlayerProfile = null;
//
//			PlayerProfile=new PlayerProfile("tempid"  


			 

		}
 
	}
}