using System.Collections;
using System.Collections.Generic;
using ConstantAssests;
using UnityEngine;

[CreateAssetMenu(fileName = "Move", menuName = "Pokemon/Move", order = 1)]
public class Move : ScriptableObject
{
    [SerializeField] private PokemonType type;
    [SerializeField] private Category category;
    [SerializeField] private int power;
    [SerializeField] private int accuracy;
    [SerializeField] private int pp;
    [SerializeField] private int maxPP;
    [SerializeField] private LocalizationAsset moveName;
    [SerializeField] private LocalizationAsset moveDescription;
    [SerializeField] private int priority;
    [SerializeField] private bool isMakingContact;
    
    public PokemonType Type => type;
    public Category MoveCategory => category;
    public int Power => power;
    public int Accuracy => accuracy;
    public int PP => pp;
    public int MaxPP => maxPP;
    //public LocalizationAsset MoveName => moveName;
    //public LocalizationAsset MoveDescription => moveDescription;
    public int Priority => priority;
    public bool IsMakingContact => isMakingContact;

    public static double GetMoveModifier(PokemonType moveType, PokemonType targetPokemonType)
    {
        double modifier = 1;
        switch (moveType)
        {
            case PokemonType.NORMAL:
                modifier = Modifiers.Normal(targetPokemonType);
                break;
            case PokemonType.FIRE:
                modifier = Modifiers.Fire(targetPokemonType);
                break;
            case PokemonType.WATER:
                modifier = Modifiers.Water(targetPokemonType);
                break;
            case PokemonType.ELECTRIC:
                modifier = Modifiers.Electric(targetPokemonType);
                break;
            case PokemonType.GRASS:
                modifier = Modifiers.Grass(targetPokemonType);
                break;
            case PokemonType.ICE:
                modifier = Modifiers.Ice(targetPokemonType);
                break;
            case PokemonType.FIGHTING:
                modifier = Modifiers.Fighting(targetPokemonType);
                break;
            case PokemonType.POISON:
                modifier = Modifiers.Poison(targetPokemonType);
                break;
            case PokemonType.GROUND:
                modifier = Modifiers.Ground(targetPokemonType);
                break;
            case PokemonType.FLYING:
                modifier = Modifiers.Flying(targetPokemonType);
                break;
            case PokemonType.PSYCHIC:
                modifier = Modifiers.Psychic(targetPokemonType);
                break;
            case PokemonType.BUG:
                modifier = Modifiers.Bug(targetPokemonType);
                break;
            case PokemonType.ROCK:
                modifier = Modifiers.Rock(targetPokemonType);
                break;
            case PokemonType.GHOST:
                modifier = Modifiers.Ghost(targetPokemonType);
                break;
            case PokemonType.DRAGON:
                modifier = Modifiers.Dragon(targetPokemonType);
                break;
            case PokemonType.DARK:
                modifier = Modifiers.Dark(targetPokemonType);
                break;
            case PokemonType.STEEL:
                modifier = Modifiers.Steel(targetPokemonType);
                break;
            case PokemonType.FAIRY:
                modifier = Modifiers.Fairy(targetPokemonType);
                break;
            default:
                Debug.LogError("Move modifier not found: " + moveType);
                break;
        }
        return modifier;
    }
    
    public enum Category
    {
        Physical,
        Special,
        Status
    }


    class Modifiers
    {
        public static double Normal(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.ROCK:
                    return 0.5;
                case PokemonType.GHOST:
                    return 0;
                case PokemonType.STEEL:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Fire(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIRE:
                    return 0.5;
                case PokemonType.WATER:
                    return 0.5;
                case PokemonType.GRASS:
                    return 2;
                case PokemonType.ICE:
                    return 2;
                case PokemonType.BUG:
                    return 2;
                case PokemonType.ROCK:
                    return 0.5;
                case PokemonType.DRAGON:
                    return 0.5;
                case PokemonType.STEEL:
                    return 2;
                default:
                    return 1;
            }
        }
        
        public static double Water(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIRE:
                    return 2;
                case PokemonType.WATER:
                    return 0.5;
                case PokemonType.GRASS:
                    return 0.5;
                case PokemonType.GROUND:
                    return 2;
                case PokemonType.ROCK:
                    return 2;
                case PokemonType.DRAGON:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Electric(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.WATER:
                    return 2;
                case PokemonType.ELECTRIC:
                    return 0.5;
                case PokemonType.GRASS:
                    return 0.5;
                case PokemonType.GROUND:
                    return 0;
                case PokemonType.FLYING:
                    return 2;
                case PokemonType.DRAGON:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Grass(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIRE:
                    return 0.5;
                case PokemonType.WATER:
                    return 2;
                case PokemonType.GRASS:
                    return 0.5;
                case PokemonType.POISON:
                    return 0.5;
                case PokemonType.GROUND:
                    return 2;
                case PokemonType.FLYING:
                    return 0.5;
                case PokemonType.BUG:
                    return 0.5;
                case PokemonType.ROCK:
                    return 2;
                case PokemonType.DRAGON:
                    return 0.5;
                case PokemonType.STEEL:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Ice(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIRE:
                    return 0.5;
                case PokemonType.WATER:
                    return 0.5;
                case PokemonType.GRASS:
                    return 2;
                case PokemonType.ICE:
                    return 0.5;
                case PokemonType.GROUND:
                    return 2;
                case PokemonType.FLYING:
                    return 2;
                case PokemonType.DRAGON:
                    return 2;
                case PokemonType.STEEL:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Fighting(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.NORMAL:
                    return 2;
                case PokemonType.ICE:
                    return 2;
                case PokemonType.POISON:
                    return 0.5;
                case PokemonType.FLYING:
                    return 0.5;
                case PokemonType.PSYCHIC:
                    return 0.5;
                case PokemonType.BUG:
                    return 0.5;
                case PokemonType.ROCK:
                    return 2;
                case PokemonType.GHOST:
                    return 0;
                case PokemonType.DARK:
                    return 2;
                case PokemonType.STEEL:
                    return 2;
                case PokemonType.FAIRY:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Poison(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.GRASS:
                    return 2;
                case PokemonType.POISON:
                    return 0.5;
                case PokemonType.GROUND:
                    return 0.5;
                case PokemonType.ROCK:
                    return 0.5;
                case PokemonType.GHOST:
                    return 0.5;
                case PokemonType.STEEL:
                    return 0;
                case PokemonType.FAIRY:
                    return 2;
                default:
                    return 1;
            }
        }
        
        public static double Ground(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIRE:
                    return 2;
                case PokemonType.ELECTRIC:
                    return 2;
                case PokemonType.GRASS:
                    return 0.5;
                case PokemonType.POISON:
                    return 2;
                case PokemonType.FLYING:
                    return 0;
                case PokemonType.BUG:
                    return 0.5;
                case PokemonType.ROCK:
                    return 2;
                case PokemonType.STEEL:
                    return 2;
                default:
                    return 1;
            }
        }
        
        public static double Flying(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.GRASS:
                    return 2;
                case PokemonType.FIGHTING:
                    return 2;
                case PokemonType.BUG:
                    return 2;
                case PokemonType.ROCK:
                    return 0.5;
                case PokemonType.STEEL:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Psychic(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIGHTING:
                    return 2;
                case PokemonType.POISON:
                    return 2;
                case PokemonType.PSYCHIC:
                    return 0.5;
                case PokemonType.DARK:
                    return 0;
                default:
                    return 1;
            }
        }
        
        public static double Bug(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIRE:
                    return 0.5;
                case PokemonType.GRASS:
                    return 2;
                case PokemonType.FIGHTING:
                    return 0.5;
                case PokemonType.POISON:
                    return 0.5;
                case PokemonType.FLYING:
                    return 0.5;
                case PokemonType.PSYCHIC:
                    return 2;
                case PokemonType.GHOST:
                    return 0.5;
                case PokemonType.DARK:
                    return 2;
                case PokemonType.STEEL:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Rock(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIRE:
                    return 2;
                case PokemonType.ICE:
                    return 2;
                case PokemonType.FIGHTING:
                    return 0.5;
                case PokemonType.GROUND:
                    return 0.5;
                case PokemonType.FLYING:
                    return 2;
                case PokemonType.BUG:
                    return 2;
                case PokemonType.STEEL:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Ghost(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.NORMAL:
                    return 0;
                case PokemonType.PSYCHIC:
                    return 2;
                case PokemonType.GHOST:
                    return 2;
                case PokemonType.DARK:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Dragon(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.DRAGON:
                    return 2;
                case PokemonType.STEEL:
                    return 0.5;
                case PokemonType.FAIRY:
                    return 0;
                default:
                    return 1;
            }
        }
        
        public static double Dark(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIGHTING:
                    return 0.5;
                case PokemonType.PSYCHIC:
                    return 2;
                case PokemonType.GHOST:
                    return 2;
                case PokemonType.DARK:
                    return 0.5;
                case PokemonType.FAIRY:
                    return 0.5;
                default:
                    return 1;
            }
        }
        
        public static double Steel(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIRE:
                    return 2;
                case PokemonType.WATER:
                    return 2;
                case PokemonType.ELECTRIC:
                    return 2;
                case PokemonType.ICE:
                    return 2;
                case PokemonType.ROCK:
                    return 2;
                case PokemonType.STEEL:
                    return 0.5;
                case PokemonType.FAIRY:
                    return 2;
                default:
                    return 1;
            }
        }
        
        public static double Fairy(PokemonType type)
        {
            switch (type)
            {
                case PokemonType.FIGHTING:
                    return 2;
                case PokemonType.DRAGON:
                    return 2;
                case PokemonType.POISON:
                    return 0.5;
                case PokemonType.STEEL:
                    return 0.5;
                case PokemonType.FAIRY:
                    return 0.5;
                default:
                    return 1;
            }
        }
    }
}
