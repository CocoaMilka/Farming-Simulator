using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Interface <c>IPlantable</c> is used for objects that can be planted.
/// </summary/>
/// <remarks>
/// Fruit(s) refer to any harvestable food (even though they may not be friuts), not the plant.
/// </remarks>
public interface IPlantable
{
	/// <summary>
	/// The amount the <c>IPlantable</c> object has grown.
	/// </summary>
	public int GrowthStage { get; set; }

	/// <summary>
	/// The amount of water the <c>IPlantable</c> object has.
	/// </summary>
	public int WaterLevel { get; set; }

	/// <summary>
	/// The number of fruits that can be harvested on the <c>IPlantable</c> object.
	/// </summary>
	public int HarvestableFruits { set; get; }

	/// <summary>
	///	Used to plant a <c>IPlantable</c> object.
	/// </summary>
	/// <returns>
	/// True if the <c>IPlantable</c> object was successfully planted; false otherwise.
	///</returns>
	bool Plant();

	/// <summary>
	/// Destroys the <c>IPlantable</c> object from reality.
	/// </summary>
	/// <returns>
	/// True if the <c>IPlantable</c> object was successfully destroyed; false otherwise.
	/// </returns>
	bool Destroy();

	/// <summary>
	///	Used to harvest a <c>IPlantable</c> object. The plant will remain.
	/// </summary>
	/// <returns>
	/// The number of fruit that is harvested from the <c>IPlantable</c> object.
	///</returns>
	int Harvest();
}