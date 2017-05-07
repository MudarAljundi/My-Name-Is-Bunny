using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LocalizaedText: MonoBehaviour {

	public string key;

	private void Start () {
		Text textComponent = GetComponent<Text>();
		textComponent.text = LocalizationManager.instance.GetLocalizedValue(key);
	}
	
}
