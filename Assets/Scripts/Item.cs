using UnityEngine;

[System.Serializable]
public class Item
{
    [Header("Item Info")]
    public string itemName;
    public Sprite itemSprite;
    [TextArea]
    public string itemDescription;

    public virtual void Use()
    {
        Debug.Log("Using item: " + itemName);
    }
}
