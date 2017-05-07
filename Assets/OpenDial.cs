using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class OpenDial : MonoBehaviour {

	private bool open = false;

	public UnityEvent onOpen;
	public UnityEvent onClose;

	public void ToggleDial () {
		open = !open;

		if (open == true) {
			onOpen.Invoke();
		} else if (open == false) {
			onClose.Invoke();
		}
		
	}
	
}
