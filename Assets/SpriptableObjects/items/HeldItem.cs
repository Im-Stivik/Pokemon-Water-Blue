using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class HeldItem : Item
{
    public Pokemon heldBy;
    public Effect effect;
    [SerializeField] private EventTrigger triggerToActivate;
    
    public virtual void Use()
    {
        effect.Activate();
    }
    
    public void SubscribeToTrigger()
    {
        System.Action action = EventMennager.current.getTrigger(triggerToActivate);
        action += Use;
    }
    
    public void UnsubscribeToTrigger()
    {
        System.Action action = EventMennager.current.getTrigger(triggerToActivate);
        action -= Use;
    }
    
}
