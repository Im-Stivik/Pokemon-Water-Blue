using System.Collections;
using System.Collections.Generic;
using ConstantAssests;
using UnityEngine;
public class Pokemon : ScriptableObject
{
    [SerializeField] private PokemonBase Base;
    [SerializeField] private int id;
    [SerializeField] private bool isShiny;
    [SerializeField] private Nature nature;
    [SerializeField] private string name;
    [SerializeField] private int level;
    [SerializeField] private int exp;
    [SerializeField] private int expToNextLevel;
    [SerializeField] private int maxHp;
    [SerializeField] private int currentHp;
    [SerializeField] private int attack;
    [SerializeField] private int defense;
    [SerializeField] private int speed;
    [SerializeField] private int specialAttack;
    [SerializeField] private int specialDefense;
    [SerializeField] private Ability ability;
    [SerializeField] private Ability hiddenAbility;
    List<Move> moves;
    
    public PokemonBase PokemonBase => Base;
    public int Id => id;
    public bool IsShiny => isShiny;
    public Nature PokemonNature => nature;
    public string Name => name;
    public int Level => level;
    public int Exp => exp;
    public int ExpToNextLevel => expToNextLevel;
    public int MaxHp => maxHp;
    public int CurrentHp => currentHp;
    public int Attack => attack;
    public int Defense => defense;
    public int Speed => speed;
    public int SpecialAttack => specialAttack;
    public int SpecialDefense => specialDefense;
    public int GetStat(Stat stat)
    {
        switch (stat)
        {
            case Stat.Hp:
                return maxHp;
            case Stat.Attack:
                return attack;
            case Stat.Defense:
                return defense;
            case Stat.Speed:
                return speed;
            case Stat.SpecialAttack:
                return specialAttack;
            case Stat.SpecialDefense:
                return specialDefense;
            default:
                return 0;
        }
    }
    public void ModifyStat(Stat stat, int amount)
    {
        switch (stat)
        {
            case Stat.Hp:
                maxHp += amount;
                break;
            case Stat.Attack:
                attack += amount;
                break;
            case Stat.Defense:
                defense += amount;
                break;
            case Stat.Speed:
                speed += amount;
                break;
            case Stat.SpecialAttack:
                specialAttack += amount;
                break;
            case Stat.SpecialDefense:
                specialDefense += amount;
                break;
        }
    }
    public Ability Ability => ability;
    public Ability HiddenAbility => hiddenAbility;
    public List<Move> Moves => moves;
    
    
    //TODO: add hold item, status, etc.

    //TODO:make a constractor

    public enum Nature
    {
        Hardy,
        Lonely,
        Brave,
        Adamant,
        Naughty,
        Bold,
        Docile,
        Relaxed,
        Impish,
        Lax,
        Timid,
        Hasty,
        Serious,
        Jolly,
        Naive,
        Modest,
        Mild,
        Quiet,
        Bashful,
        Rash,
        Calm,
        Gentle,
        Sassy,
        Careful,
        Quirky
    }

    public enum Status
    {
        None,
        Paralyzed,
        Poisoned,
        Freeze,
        Sleep
        //TODO: make a complete system of status conditions
    }
}
