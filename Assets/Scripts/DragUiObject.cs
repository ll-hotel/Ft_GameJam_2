using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using UnityEditor;

public class DragUiObject : MonoBehaviour, IDragHandler, IInitializePotentialDragHandler, IDropHandler
{
	[SerializeField]
	public Canvas canvas;
	public bool isDragging;
	public void OnDrag(PointerEventData eventData)
	{
		isDragging = true;
		GetComponent<RectTransform>().anchoredPosition += eventData.delta / canvas.scaleFactor;
	}
	public void OnDrop(PointerEventData enventData)
	{
		isDragging = false;
	}
	public void OnInitializePotentialDrag(PointerEventData eventData)
	{
		eventData.useDragThreshold = false;
	}
}
