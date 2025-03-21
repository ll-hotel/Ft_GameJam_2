using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.Animations;

public class ItemSlot : MonoBehaviour, IDropHandler
{
    public ItemData item;
    public void OnDrop(PointerEventData eventData)
    {
        if (eventData.pointerDrag != null)
        {
            eventData.pointerDrag.transform.parent = transform;
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = Vector2.zero;
            item = eventData.pointerDrag.GetComponent<UpgradeItem>().Item;

        }
    }
}
