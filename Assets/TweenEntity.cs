using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TweenEntity : MonoBehaviour {

	public List<Vector3> targetPositions;
	public float speed = 0.5f;
	private int targetIndex;

	[System.Serializable]
	public class AdvancedValues {
		public string tweenType = "Lerp";
	}
	public AdvancedValues advancedValues;

	private string entityType;
	private Transform myTransform;
	private RectTransform myRectTransform;

	private void Start() {
		myTransform = transform;
		if (GetComponent<RectTransform>()) {
			entityType = "UI";
			myRectTransform = GetComponent<RectTransform>();
		}
	}

	private IEnumerator Tween() {

		float i = 0;
		float rate = 1f * speed;

		while (i < 0.3) {
			i += Time.deltaTime * rate;

			if (entityType == "UI") {

				myRectTransform.anchoredPosition = Vector2.Lerp(myRectTransform.anchoredPosition, targetPositions[targetIndex], i);
			}
			else if (entityType == "WorldGameObject") {

				myTransform.position = Vector3.Lerp(myTransform.position, targetPositions[targetIndex], i);
			}
			yield return null;
		}

		print(i);
	}
	public void GoToTween(int targetI) {
		targetIndex = targetI;
		StartCoroutine(Tween());
	}
}
