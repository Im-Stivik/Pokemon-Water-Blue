using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : ScriptableObject
{
    public PokemonType type;
    public Category category;
    public int power;
    public int accuracy;
    public int pp;
    public int maxPP;
    public LocalizationAsset moveName;
    public LocalizationAsset moveDescription;
    public int priority;
    public bool isMakingContact;

    public enum Category
    {
        Physical,
        Special,
        Status
    }
}
