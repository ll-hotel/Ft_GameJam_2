using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;
public class DisplayTowerInventory : MonoBehaviour
{
    private Inventory   inventory;
    private GameObject  inventoryWindow;
    private Sprite      test;

    void Start()
    {
        // inventory = GetComponent<Tower>().inventory;
        inventoryWindow =  GameObject.FindWithTag("TowerInventory");
        inventoryWindow.transform.Find("TowerPreview").GetComponent<Image>().sprite = test;

    }
}
