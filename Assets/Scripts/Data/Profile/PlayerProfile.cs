using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Data.Profile{

	public sealed class PlayerProfile :BasePlayerProfile {


		private readonly string id = string.Empty;
		private readonly string Name=string.Empty;
		private Texture2D ProfileImage;
		private string profileURl;


		public PlayerProfile(string id ,string name,Texture2D profileImage,string profileURL)
		{
		
			this.id = id;
			this.Name = name;
			this.ProfileImage = ProfileImage;
			this.profileURl = profileURl;
		}

		protected override void GetIcon(Action<Texture2D> onSuccess, Action onError)
		{


			if (onSuccess != null)
			{
				onSuccess(ProfileImage);
			}
		}

		/// <summary>
		/// Return name for guest
		/// </summary>
		protected override string name {
			
			get {

				return Name;
			}
		}

		protected override string Id
		{
			get { return id; }
		}
		protected override string URL
		{
			get { 
				//				Debug.LogError("Profile url "+profileURl);
				return profileURl; 
			}
		}


	}

}