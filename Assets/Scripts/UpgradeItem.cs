using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;

public class UpgradeItem : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public ItemData Item;
    public GameObject Overlay;
    
    public void OnDrag(PointerEventData eventData)
    {
        transform.parent = Overlay.transform;
        GetComponent<CanvasGroup>().alpha = .5f;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        GetComponent<CanvasGroup>().alpha = 1f;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
