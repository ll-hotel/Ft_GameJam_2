using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEditor;
using UnityEngine.EventSystems;
using UnityEngine;
using UnityEngine.UI;
public class DisplayTowerInventory : MonoBehaviour, IPointerClickHandler
{
	private TowerInventory	towerInventory;
	private GameObject		inventoryWindow;

	void Start()
	{
		towerInventory = GetComponent<TowerInventory>();
		inventoryWindow =  GameObject.FindWithTag("TowerInventory").transform.GetChild(0).gameObject;

	}

	public void OnPointerClick(PointerEventData eventData)
	{
		if (inventoryWindow.activeSelf == false)
			ShowWindows();
	}
	public void ShowWindows()
	{
		inventoryWindow.transform.parent.GetComponent<TowerWindowsManager>().Tower = gameObject;
		inventoryWindow.SetActive(true);
		inventoryWindow.transform.Find("Title")
			.GetComponent<TextMeshProUGUI>().text = towerInventory.gameObject.name;
		inventoryWindow.transform.Find("TowerPreview")
			.GetComponent<Image>().sprite = towerInventory.icon;
		if (towerInventory.inventory.Items.Count == 1)
			inventoryWindow.GetComponent<TowerWindowsManager>()
				.UpgradeItem[0] = towerInventory.inventory.Items[0].item;
		if (towerInventory.inventory.Items.Count == 2)
			inventoryWindow.GetComponent<TowerWindowsManager>()
				.UpgradeItem[1] = towerInventory.inventory.Items[1].item;
		if (towerInventory.inventory.Items.Count == 3)
			inventoryWindow.GetComponent<TowerWindowsManager>()
				.UpgradeItem[2] = towerInventory.inventory.Items[2].item;
	}
}
