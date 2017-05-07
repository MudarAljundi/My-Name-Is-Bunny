using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Event_Timer: MonoBehaviour {

	public UnityEvent onTimerEnd;

	public float timerEnd = 0;
	public bool repeat = false;
	public bool startTimerOnInit = false;

	private void Start() {
		if (startTimerOnInit == true) {
			StartTimer();
		}
	}
	public void StartTimer() {
		StartCoroutine(TimerCountdown());
	}

	private IEnumerator TimerCountdown() {
		yield return new WaitForSeconds(timerEnd);
		onTimerEnd.Invoke();

		if (repeat == true) {
			StartCoroutine(TimerCountdown());
		}
	}
}
