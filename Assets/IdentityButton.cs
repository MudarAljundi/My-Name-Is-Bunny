using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IdentityButton : MonoBehaviour {

	//private bool none = stuff;

	public void IdentityButtonClicked () {
		if (GetComponent<IdentityValues>().firstName == "") {
			CreateNewIdentityDialogue();
		}
		else {
			CreateNewIdentityDialogue();
		}
	}
	private void CreateNewIdentityDialogue() {

	}
	private void SelectThisIdentity() {

	}


}
