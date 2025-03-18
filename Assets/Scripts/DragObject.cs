using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UIElements;
using UnityEngine.InputSystem;


[ExecuteInEditMode]
public class DragObject : MonoBehaviour,IDragHandler, IInitializePotentialDragHandler
{
	public void OnDrag(PointerEventData eventData)
	{
		GetComponent<Rigidbody2D>().position =  Camera.main.ScreenToWorldPoint(eventData.position);
	}
	public void OnInitializePotentialDrag(PointerEventData eventData)
	{
		eventData.useDragThreshold = false;
	}
}
