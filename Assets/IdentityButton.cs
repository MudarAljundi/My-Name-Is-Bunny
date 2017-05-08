using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class IdentityButton : MonoBehaviour {

	public Color femaleColor;
	public Color maleColor;

	public void Start() {
		if (GetComponent<IdentityStats>().gender == "Female") {
			GetComponent<Image>().color = femaleColor;
		}
		if (GetComponent<IdentityStats>().gender == "Male") {
			GetComponent<Image>().color = maleColor;
		}
	}
	public void IdentityButtonClicked () {
		if (GetComponent<IdentityStats>().firstName == "") {
			CreateNewIdentityDial();
		}
		else {
			DisplayStats();
		}
	}
	private void CreateNewIdentityDial() {

	}
	private void DisplayStats() {

	}


}
