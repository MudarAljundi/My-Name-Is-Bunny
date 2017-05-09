using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;
using System;

public class DraggableObject : MonoBehaviour, IBeginDragHandler, IDragHandler, IEndDragHandler {

	public bool lockHorizontal = false;
	public bool lockVertical = false;
	public Vector2 keepInXSpace = new Vector2 (-640, 640);
	public Vector2 keepInYSpace = new Vector2(-360, 360);

	private bool isDragging = false;

	private Vector2 mouseOffset;
	private Vector2 goTo;
	private RectTransform myRectTransform;

	private void Start() {
		myRectTransform = GetComponent<RectTransform>();
	}

	public void OnBeginDrag(PointerEventData eventData) {
		mouseOffset = myRectTransform.anchoredPosition - (Vector2)Input.mousePosition;
		isDragging = true;
	}
	public void OnEndDrag(PointerEventData eventData) {
		isDragging = false;
	}
	public void OnDrag(PointerEventData eventData) {
	}

	private void Update() {

		if (isDragging == false) {
			return;
		}

		// GetDrag()
		if (Input.GetMouseButton(0) == true) {

			goTo = mouseOffset + (Vector2)Input.mousePosition;
		}

		if (lockHorizontal == true) {
			goTo = new Vector2(0, goTo.y);
		} else if (lockVertical == true) {
			goTo = new Vector2(goTo.x, 0);
		}

		myRectTransform.anchoredPosition = goTo;

		// keep in canvas()
		myRectTransform.anchoredPosition = new Vector2(Mathf.Clamp(myRectTransform.anchoredPosition.x, keepInXSpace.x, keepInXSpace.y),
		                                               Mathf.Clamp(myRectTransform.anchoredPosition.y, keepInYSpace.x, keepInYSpace.y));
		

	}
}
