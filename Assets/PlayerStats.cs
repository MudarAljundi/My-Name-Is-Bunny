using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour {

	public float money = 20f;
	public float livingWage = 20f;
	// rent, food.

	public float productiveHours = 60f;
	public string healthStatus = "fair"; // fair, passable, ill, crippling
	//public string mentalStatus = "fair"; // OR happiness. fair, passable, ill, crippling
	public float diligence = 50f; // out of 100

}
