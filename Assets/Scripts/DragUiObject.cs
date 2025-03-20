using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using UnityEditor;


[ExecuteInEditMode]
public class DragUiObject : MonoBehaviour, IDragHandler, IInitializePotentialDragHandler, IDropHandler
{
	[SerializeField]
	private Canvas canvas;
	public bool isDragging;
	public void OnDrag(PointerEventData eventData)
	{
		isDragging = true;
		Vector2 position;
		RectTransformUtility.ScreenPointToLocalPointInRectangle(
		(RectTransform)canvas.transform, 
		eventData.position, 
		canvas.worldCamera,
		out position);
		transform.position = canvas.transform.TransformPoint(position);
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
