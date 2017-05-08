using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TimelineMovement : MonoBehaviour {

	public int calanderIndex; // out of 64. How many weeks off from the player is this event?

	private void Start() {
		GameManager.timelineMovables.Add(GetComponent<TimelineMovement>());
	}

	private void Update() {
		GetComponent<RectTransform>().anchoredPosition = new Vector2(25 * calanderIndex, GetComponent<RectTransform>().anchoredPosition.y);

		if (calanderIndex == 0 && GetComponent<TimelineEffect>()) {
			GetComponent<TimelineEffect>().Invoke();
		}
	}
	public void MoveOneTurn() {
		calanderIndex -= 1;
	}
	
}
