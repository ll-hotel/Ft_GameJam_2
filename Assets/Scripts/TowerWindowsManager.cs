using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TowerWindowsManager : MonoBehaviour
{
	public ItemData[] UpgradeItem;
	public GameObject Tower;
	[SerializeField]
	private TextMeshProUGUI description;

    void Start()
    {
        LeftSlot();
		CloseWindows();
    }
    public void CloseWindows()
	{
		transform.GetChild(0).gameObject.SetActive(false);
	}

	public void LeftSlot()
	{
		if (UpgradeItem.Length == 1)
			description.text = UpgradeItem[0].description;
		else
			description.text = "No upgrade install FUCK";
	}

	public void MidlleSlot()
	{
		if (UpgradeItem.Length == 2)
			description.text = UpgradeItem[1].description;
		else
			description.text = "No upgrade install YOU";
	}
	public void RightSlot()
	{
		if (UpgradeItem.Length == 3)
			description.text = UpgradeItem[2].description;
		else
			description.text = "No upgrade install BITCH";
	}

	public bool NewItem(ItemData item)
	{
		if (!Tower.GetComponent<TowerInventory>().inventory.AddItem(new ItemInstance(item)))
			return false;
		return true;
	}
	public void PopItem(ItemData item)
	{
		int i;

		var ItemList = Tower.GetComponent<TowerInventory>().inventory.Items;
		for (i = 0; ItemList[i].item.name != item.name ; i ++);
		Tower.GetComponent<TowerInventory>().inventory.Items.Remove(ItemList[i]);
	}
}
