using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

	public static int gameTurn = 0;
	public static List<TimelineMovement> timelineMovables;

	public void Start() {
		timelineMovables = new List<TimelineMovement>();
	}
	public void MoveGameOneTurn() {
		for (int i = 0; i < timelineMovables.Count; i += 1) {
			timelineMovables[i].MoveOneTurn();
		}
	}

}
