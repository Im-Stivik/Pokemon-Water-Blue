using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : ScriptableObject
{
    [SerializeField] protected LocalizationAsset itemName;
    [SerializeField] protected LocalizationAsset itemDescription;
    [SerializeField] protected Sprite itemIcon;
    [SerializeField] protected int itemID;
    [SerializeField] protected int itemPrice;

    public LocalizationAsset ItemName => itemName;
    public LocalizationAsset ItemDescription => itemDescription;
    public Sprite ItemIcon => itemIcon;
    public int ItemID => itemID;
    public int ItemPrice => itemPrice;
    
}
