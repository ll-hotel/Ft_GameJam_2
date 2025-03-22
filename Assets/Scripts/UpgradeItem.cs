using System.Collections;
using System.Collections.Generic;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UIElements;

public class UpgradeItem : MonoBehaviour, IDragHandler, IEndDragHandler
{
    public ItemData Item;
    public bool notSet = true;
    public Vector2 startPosition;
    public GameObject Overlay;

    void Start()
    {
        startPosition = GetComponent<RectTransform>().anchoredPosition;
    }
    public void OnDrag(PointerEventData eventData)
    {
        transform.SetParent(Overlay.transform, true);
        GetComponent<CanvasGroup>().alpha = .5f;
        GetComponent<CanvasGroup>().blocksRaycasts = false;
    }

    public void OnEndDrag(PointerEventData eventData)
    {
        if (!notSet && transform.parent.gameObject == Overlay)
            Destroy(this.gameObject);
        else if (notSet && transform.parent.gameObject == Overlay)
            GetComponent<RectTransform>().anchoredPosition = startPosition;
        GetComponent<CanvasGroup>().alpha = 1f;
        GetComponent<CanvasGroup>().blocksRaycasts = true;
    }
}
