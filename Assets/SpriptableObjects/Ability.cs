using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Ability : ScriptableObject
{
    [SerializeField] private LocalizationAsset abilityName;
    [SerializeField] private LocalizationAsset abilityDescription;
    [SerializeField] Effect effect;
}
