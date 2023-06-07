 
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityLibrary.Additions;
using Data.SerealizationPoint;
using Interfaces.Serealization;
using Server.Data;
 

namespace Data.SerealizationPoint
{
	/// <summary>
	/// Responsible for saving and loading data 
	/// </summary>
	public sealed class GameSaver : Singletone<GameSaver>
	{
		public GameSaver()
		{
			LoadPoint = null;
			SavePoint = null;
		}

		private const string WORK_FILE_NAME = "db";

		public SerializationPoint SavePoint { get; set; }

		public SerializationPoint LoadPoint { get; set; }

		private string PersistentPath
		{
			get
			{
				return Application.persistentDataPath + "/{0}.xml";
			}
		}

		private IEnumerable<ISerializable> SaveSerializables
		{
			get
			{
				if (SavePoint == null)
					SavePoint = Object.FindObjectOfType<SavePoint>();

				if(SavePoint == null)
					SavePoint = Object.FindObjectOfType<GameSavePoint>();



				if (SavePoint != null)
					return SavePoint.Serializables;

				Debug.LogWarning(string.Format("GameSaver: failed find save point for scene {0}.",
					Application.loadedLevelName));
				return new List<ISerializable>();
			}
		}

		private IEnumerable<ISerializable> LoadSerializables
		{
			get
			{
				if (LoadPoint == null)
					LoadPoint = Object.FindObjectOfType<LoadPoint>();

				if (LoadPoint == null)
					LoadPoint = Object.FindObjectOfType<GameLoadPoint>();


				DebugClass.LogMagenta ("Savepoint "+LoadPoint);

				if (LoadPoint != null)
					return LoadPoint.Serializables;

				Debug.LogWarning(string.Format("GameSaver: failed find load point for scene {0}.",
					Application.loadedLevelName));
				return new List<ISerializable>();
			}
		}

		public void SaveSession()
		{
			
			var data = ServerPlatform.Instance.PlayerProfile.SavedData;

			foreach (var s in SaveSerializables)
				s.Save(data);
			
 			ServerPlatform.Instance.PlayerProfile.SavedData = data;
		//	ServerPlatform.Instance.SaveUserData();
			///NOW CONSUME ALL PRODUCTS
	 

		}

		public void RestoreSession()
		{
			if (ServerPlatform.Instance.PlayerProfile.SavedData == null)
			{
				Debug.LogError ("1");
				var data = new SavedData();
				foreach (var s in LoadSerializables)
					s.Load(data);
			}
			else
			{

				var data = ServerPlatform.Instance.PlayerProfile.SavedData;
				Debug.LogError ("2 "+LoadSerializables);

				foreach (var s in LoadSerializables)
				{
					Debug.LogError ("2"+LoadSerializables);

					s.Load(data);
				}
			}

		}

		#if UNITY_EDITOR

		public void DeleteFile()
		{
			if (File.Exists(string.Format(PersistentPath, WORK_FILE_NAME)))
				File.Delete(string.Format(PersistentPath, WORK_FILE_NAME));
		}

		#endif
	}
}
