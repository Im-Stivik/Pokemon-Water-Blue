using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EventMennager : MonoBehaviour
{
    public static EventMennager current;
    private void Awake()
    {
        current = this;
    }
    
    
    public event System.Action onEnemyDeath;
    public void EnemyDeath()
    {
        if (onEnemyDeath != null)
        {
            onEnemyDeath();
        }
    }
    
    public System.Action getTrigger(EventTrigger trigger)
    {
        //TODO: return the correct event
        return onEnemyDeath;
    }
}
