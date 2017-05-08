using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FadeEntity : MonoBehaviour {

	public float animationEndInSeconds = 0.5f;

	public void GoFadeIn() {
		StartCoroutine(FadeIn());
	}
	public void GoFadeOut() {
		StartCoroutine(FadeOut());
	}
	private IEnumerator FadeIn() {

		Color color = GetComponent<Image>().color;

		for (float i = 0; i < 1; i += Time.deltaTime / animationEndInSeconds) {
			color.a = i;
			GetComponent<Image>().color = color;
			yield return null;
		}
		color.a = 1;
		GetComponent<Image>().color = color;
	}
	private IEnumerator FadeOut() {

		Color color = GetComponent<Image>().color;

		for (float i = 1; i > 0; i -= Time.deltaTime / animationEndInSeconds) {
			color.a = i;
			GetComponent<Image>().color = color;
			yield return null;
		}
		color.a = 0;
		GetComponent<Image>().color = color;
	}
}
