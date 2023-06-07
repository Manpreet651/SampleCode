using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 
using System;
using Interfaces.Serealization;

namespace Data.Profile
{
	
	public abstract class BasePlayerProfile : IPlayerProfile
	{


		protected abstract string Id { get; }

		protected abstract string name { get; }


		protected abstract string URL { get; }

		private readonly PlayerStatistic statistic = new PlayerStatistic ();

		protected abstract void GetIcon (Action<Texture2D> onSuccess, Action onError);

		string IProfile.URL {
			get { return URL; }
		}

		string IProfile.Id {
			get { return Id; }
		}

		void IPlayerProfile.GetIcon (Action<Texture2D> onSuccess, Action onError)
		{
			GetIcon (onSuccess, onError);
		}

		PlayerStatistic IPlayerProfile.Statistic {
			get {
				return statistic;
			}
	
		}

		ISavedData IPlayerProfile.SavedData { get; set; }

		string IPlayerProfile.Name {
			get { return name; }
		}

	}

}
