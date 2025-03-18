using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public enum ItemId
{
    EnderPearl,
    RottenGrandma,
    Amogus
}
[ExecuteInEditMode]
public class Item : MonoBehaviour, IPointerDownHandler, IPointerUpHandler, IPointerClickHandler, IPointerEnterHandler, IPointerExitHandler
{
	public ItemId ItemName;
	public SpriteRenderer spriteRenderer;
	public Sprite[] ItemSprite;
	
	[TextArea] public string description;

    [ExecuteInEditMode]

    void OnValidate()
    {
        Set_Item(ItemName);
    }

    void Set_Item(ItemId id)
	{
		switch (ItemName)
		{
			case ItemId.EnderPearl:
			{
				spriteRenderer.sprite = ItemSprite[0];
				description = "It's a Ender Pearl !";
				break ;
			}
			case ItemId.RottenGrandma:
			{
				spriteRenderer.sprite = ItemSprite[1];
				description = "c'est mamie :]";
				break ;
			}
			case ItemId.Amogus:
				spriteRenderer.sprite = ItemSprite[2];
				description = "AMONGUS";
				break ;
		}
	}

	public void OnPointerDown(PointerEventData eventData)
    {

    }

    public void OnPointerUp(PointerEventData eventData)
    {
        
    }
    public void OnPointerClick(PointerEventData eventData)
    {
        printDescription();
    }
    public void OnPointerEnter(PointerEventData eventData)
    {
        
    }
    public void OnPointerExit(PointerEventData eventData)
    {
        
    }
	public void printDescription()
	{
		Debug.Log(description);
	}
}
