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
        if (eventData.pointerDrag != null && eventData.pointerDrag.GetComponent<UpgradeItem>().notSet)
        {
            eventData.pointerDrag.transform.SetParent(transform, true);
            item = eventData.pointerDrag.GetComponent<UpgradeItem>().Item;
            if (!transform.parent.parent.GetComponent<TowerWindowsManager>().NewItem(item))
            {
                eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = eventData.pointerDrag.GetComponent<UpgradeItem>().startPosition;
            }
            eventData.pointerDrag.GetComponent<RectTransform>().anchoredPosition = this.GetComponent<RectTransform>().anchoredPosition;
            eventData.pointerDrag.GetComponent<RectTransform>().localPosition = Vector2.zero;
            eventData.pointerDrag.GetComponent<UpgradeItem>().notSet = false;

        }
    }
}
