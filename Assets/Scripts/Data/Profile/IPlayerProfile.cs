using System;
 
using UnityEngine;
using Interfaces.Serealization;

namespace Data.Profile
{
	/// <summary>
	/// Profile of current user. Contain functional that not
	/// avaliable for profiles of friends or oponents
	/// </summary>
	public interface IPlayerProfile : IProfile
	{


		/// <summary>


		/// <summary>
		/// Information about player
		/// </summary>
		PlayerStatistic Statistic { get; }


		/// <summary>
		/// User data, which contains information about player and save on server
		/// </summary>
		ISavedData SavedData { get; set; }

		/// <summary>
		/// Current user name
		/// </summary>
		String Name { get; }

		/// <summary>
		/// Return icon of player
		/// </summary>
		void GetIcon(Action<Texture2D> onSuccess, Action onError);


	}
}
