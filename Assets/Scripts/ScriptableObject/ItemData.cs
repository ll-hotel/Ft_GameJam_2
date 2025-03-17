using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ItemData : ScriptableObject
{
	public String ItemName;
	public Sprite ItemSprite;
	[TextArea] 
	public string description;
	public int amount;
}
