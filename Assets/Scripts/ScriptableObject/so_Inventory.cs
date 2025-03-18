using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInstance
{
    public ItemData itemType;
    public int amount;
    public ItemInstance(ItemData itemData)
    {
        itemType = itemData;
        amount = itemData.amount;
    }
}

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public List<ItemInstance> Items = new();
}
