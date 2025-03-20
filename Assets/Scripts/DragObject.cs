using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;
using UnityEditor;


[ExecuteInEditMode]
public class DragObject : MonoBehaviour, IDragHandler, IInitializePotentialDragHandler, IDropHandler
{
	public bool isDragging;
	public void OnDrag(PointerEventData eventData)
	{
		isDragging = true;
		GetComponent<Rigidbody2D>().position =  Camera.main.ScreenToWorldPoint(eventData.position);
	}
	public void OnDrop(PointerEventData enventData)
	{
		isDragging = false;
	}
	public void OnInitializePotentialDrag(PointerEventData eventData)
	{
		// eventData.useDragThreshold = false;
	}
}
