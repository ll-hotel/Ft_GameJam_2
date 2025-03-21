using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class TowerInventory : MonoBehaviour
{
    public Sprite  icon;
    public Inventory inventory;

    void Start()
    {
        icon = GetComponent<SpriteRenderer>().sprite;
        inventory = Inventory.CreateInstance<Inventory>();
        AssetDatabase.CreateAsset(inventory, "Assets/Scripts/ScriptableObject/TowerInventory.asset");
        AssetDatabase.SaveAssets();
        EditorUtility.FocusProjectWindow();

        Selection.activeObject = inventory;
        inventory.maxItems = 3;
    }

    // void OnValidate()
    // {
    //     icon = GetComponent<SpriteRenderer>().sprite;
    // }
}
