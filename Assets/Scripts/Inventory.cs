using UnityEngine;


[System.Serializable]

public class Inventory
{
    [Header("Inventory Info")]
    public string inventoryName;
    public Item[] items;
    public int inventorySize;

    public void AddItem(Item item)
    {
        for (int i = 0; i < items.Length; i++)
        {
            if (items[i] == null)
            {
                items[i] = item;
                Debug.Log("Added item: " + item.itemName);
                return;
            }
        }
        Debug.Log("Inventory is full!");
    }
}
