using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DisplayIdentityName : MonoBehaviour {

	//private bool none = stuff;

	private void Start () {
		GetComponent<Text>().text = transform.parent.GetComponent<IdentityValues>().firstName + " " + transform.parent.GetComponent<IdentityValues>().lastName;
	}
	
}
