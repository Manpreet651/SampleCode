using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Interfaces.Serealization;


namespace Data.Profile
{
/// <summary>
/// Data about general plyer statistics. 
/// </summary>
public class PlayerStatistic : ISerializable {

	/// <summary>
	/// Avarage speed of user for all trips
	/// </summary>
	private uint avarageSpeed=0;

	/// <summary>
	/// Total Distance coverd by user  
	/// </summary>
	private uint totalDistance=0;

	/// <summary>
	/// Total traveling time of user
	/// </summary>
	private uint totalTime = 0;

	/// <summary>
	/// Max speed achived by user
	/// </summary>
	private uint maxSpeed = 0;



	public uint AvarageSpeed{
		get { return avarageSpeed; }
	}
	public uint TotalDistance{
		get { return totalDistance; }
	}
	public uint TotalTime {
		get { return totalTime; }
	}
	public uint MaxSpeed {
		get { return maxSpeed; }
	}


	void ISerializable.Save(ISavedData saveData)
	{
		saveData.PlayerStatisticSavedData = new PlayerStatisticSavedData {

			avarageSpeed = this.avarageSpeed,
			totalDistance=this.totalDistance,
			totalTime=this.totalTime,
			maxSpeed=this.maxSpeed
		};
	}
	void ISerializable.Load(ISavedData saveData)
	{
			Debug.LogError ("called");
		var pssd = saveData.PlayerStatisticSavedData;
		if (pssd == null) {
			Debug.LogError ("Error in loading Data");

			return;
		}

		this.avarageSpeed = pssd.avarageSpeed;
		this.totalDistance = pssd.totalDistance;
		this.totalTime = pssd.totalTime;
		this.maxSpeed = pssd.maxSpeed;

	}
}

}