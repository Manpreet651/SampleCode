using System;
 
 
using UnityEngine;
 
//using UnityLibrary.Social.Facebook;
using Interfaces.Serealization;
using Data.SerealizationPoint;

namespace Data.Profile

{
	/// <summary>
	/// This profile generated if something wrong during autorization
	/// </summary>
	public sealed class InvalidPlayerProfile : IPlayerProfile
	{
		string IProfile.Id
		{
			get
			{
				Debug.LogWarning("InvalidGamePlayerProfile: id empty due to profile invalid.");
				return "test";//FacebookProfile.INVALID_FACEBOOK_ID;
			}
		}
		string IProfile.URL
		{
			get
			{
				Debug.LogWarning("InvalidGamePlayerProfile: id empty due to profile invalid.");
				return "test";//FacebookProfile.INVALID_FACEBOOK_ID;
			}
		}

//		IPouch<int> IPlayerProfile.MoneyPoch
//		{
//			get
//			{
//				Debug.LogWarning("InvalidGamePlayerProfile: profile is invalid, return empty pouch.");
//				return new IntPouch();
//			}
//		}

//		PlayerLevelData IPlayerProfile.LevelData
//		{
//			get
//			{
//				Debug.LogWarning("InvalidGamePlayerProfile: return default player level data due to invalid profile.");
//				return new PlayerLevelData();
//			}
//		}

		PlayerStatistic IPlayerProfile.Statistic
		{
			get
			{
				Debug.LogWarning("InvalidGamePlayerProfile: return default player statistic due to invalid profile.");
				return new PlayerStatistic();
			}
		}

//		PlayerTableSavedData IPlayerProfile.tableData
//		{
//			get
//			{
//				return new  PlayerTableSavedData();
//			}
//		}
//		PlayerLeagues IPlayerProfile.Leagues
//		{
//			get
//			{
//				Debug.LogWarning("InvalidGamePlayerProfile: return default player leagues due to invalid profile.");
//				return new PlayerLeagues();
//			}
//		}

		ISavedData IPlayerProfile.SavedData
		{
			get
			{
				Debug.LogWarning("InvalidGamePlayerProfile: return default data due to invalid profile.");
				return new SavedData();
			}
			set
			{
				Debug.LogWarning("InvalidGamePlayerProfile: can't set user data due to invalid profile.");
			}
		}

		string IPlayerProfile.Name
		{
			get
			{
				Debug.LogWarning("InvalidGamePlayerProfile: return default name data due to invalid profile.");
				return "Maks";
			}
		}

		void IPlayerProfile.GetIcon(Action<Texture2D> onSuccess, Action onError)
		{
			var texture = new Texture2D((int) 10,
				1);
			if (onSuccess != null)
				onSuccess(texture);
		}
	}
}
