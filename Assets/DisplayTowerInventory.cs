using System.Collections;
using System.Collections.Generic;
using Microsoft.Unity.VisualStudio.Editor;
using Unity.VisualScripting;
using UnityEngine;

public class DisplayTowerInventory : MonoBehaviour
{
    private Inventory   inventory;
    private GameObject  inventoryWindow;

    void Start()
    {
        // inventory = GetComponent<Tower>().inventory;
        inventoryWindow =  GameObject.FindWithTag("TowerInventory");
        inventoryWindow.transform.Find("TowerPreview").GetComponent<Image>();
    }
}
