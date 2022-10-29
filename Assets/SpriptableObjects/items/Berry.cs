using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.Events;

[CreateAssetMenu(fileName = "Berry", menuName = "Items/Berry",order = 1)]
public class Berry : HeldItem
{
    public override void Use()
    {
        base.Use();
        Debug.Log("Berry used");
        this.UnsubscribeToTrigger();
        //TODO: remove the item from the pokemon 
    }
}
