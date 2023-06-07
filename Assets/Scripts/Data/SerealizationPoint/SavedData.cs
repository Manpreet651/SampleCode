using Interfaces.Serealization;

namespace Data.SerealizationPoint
{
	/// <summary>
	/// Storage of datas what needs to be saved
	/// </summary>
	public sealed class SavedData : ISavedData
	{
//		private LevelSavedData LevelSavedData = new LevelSavedData();
//		private CuesData lastCueData = null;
		private PlayerStatisticSavedData playerStatisticSavedData = new PlayerStatisticSavedData();
//		private PlayerLeaguesSavedData playerLeaguesSavedData = new PlayerLeaguesSavedData();
//		private PlayerTableSavedData playerTableSavedData= new PlayerTableSavedData();

//		LevelSavedData ISavedData.LevelSavedData
//		{
//			get { return LevelSavedData; }
//			set
//			{
//				if (value != null)
//					LevelSavedData = value;
//			}
//		}
//
//		CuesData ISavedData.CuesData
//		{
//			get { return lastCueData; }
//			set
//			{
//				if (value != null)
//				{
//					lastCueData = value;
//				}
//			}
//		}

		PlayerStatisticSavedData ISavedData.PlayerStatisticSavedData
		{
			get { return playerStatisticSavedData; }
			set
			{
				if (value != null)
				{
					playerStatisticSavedData = value;
				}
			}
		}

//		PlayerLeaguesSavedData ISavedData.PlayerLeaguesSavedData
//		{
//			get { return playerLeaguesSavedData; }
//			set
//			{
//				if (value != null)
//				{
//					playerLeaguesSavedData = value;
//				}
//			}
//		}
//		PlayerTableSavedData ISavedData.PlayerTableSavedData
//		{
//			get { return playerTableSavedData; }
//			set
//			{
//				if (value != null)
//				{
//					playerTableSavedData = value;
//				}
//			}
//		}
	}
}
