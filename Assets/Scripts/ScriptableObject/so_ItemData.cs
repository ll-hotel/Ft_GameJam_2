using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public enum Category {Collectible, Upgrade};


[CreateAssetMenu]
public class ItemData : ScriptableObject
{
	public String	ItemName;
	public Sprite	ItemSprite;
	public Category	category;
	[TextArea]
	public String	description;
	public int amount;
}
