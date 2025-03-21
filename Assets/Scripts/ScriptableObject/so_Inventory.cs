using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class ItemInstance
{
    public ItemData item;
    public int amount;
    public Category category;
    public ItemInstance(ItemData itemData)
    {
        item = itemData;
        category = itemData.category;
        amount = itemData.amount;
    }
}

[CreateAssetMenu]
public class Inventory : ScriptableObject
{
    public int maxItems = 10; 
    public List<ItemInstance> Items = new();
    public bool AddItem(ItemInstance itemToAdd)
    {
        // Finds an empty slot if there is one
        for (int i = 0; i < Items.Count; i++)
        {
            if (Items[i] == null)
            {
                Items[i] = itemToAdd;
                return true;
            }
        }

        // Adds a new item if the inventory has space
        if (Items.Count < maxItems)
        {
            Items.Add(itemToAdd);
            return true;
        }

        Debug.Log("No space in the inventory");
        return false;
    }
}