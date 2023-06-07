using System.Collections.Generic;
using System.Linq;
using Interfaces.Serealization;

namespace Data.SerealizationPoint
{
	/// <summary>
	/// Contains save data for current game
	/// </summary>
	public sealed class GameSavePoint : SavePoint
	{
		public override IEnumerable<ISerializable> Serializables
		{
			get
			{
				var list = base.Serializables.ToList();
//				list.Add(GameFlow.Instance.PlayerProfile.LevelData);
//				list.Add(GameFlow.Instance.PlayerProfile.Leagues);
				list.Add(GameFlow.Instance.PlayerProfile.Statistic);
//				list.Add(GameFlow.Instance.CueManager);
				return list;
			}
		}
	}
}

