using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayIdentityName : MonoBehaviour {

	//private bool none = stuff;

	private void Start () {
		if (transform.parent.GetComponent<IdentityStats>().firstName == "") {

			GetComponent<LocalizedText>().SetToLocalizedText();
		} else {
			GetComponent<Text>().text = transform.parent.GetComponent<IdentityStats>().firstName + " " + transform.parent.GetComponent<IdentityStats>().lastName;

		}
	}
	
}
