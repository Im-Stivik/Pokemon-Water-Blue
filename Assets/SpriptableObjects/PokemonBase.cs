using System;
using System.Collections;
using System.Collections.Generic;
using ConstantAssests;
using Unity.VisualScripting;
using UnityEngine;

public class PokemonBase : ScriptableObject
{
    [SerializeField] private LocalizationAsset pokemonName;
    [SerializeField] private int pokedexNumber;
    [SerializeField] private LocalizationAsset entry;
    [SerializeField] private PokemonType type1;
    [SerializeField] private PokemonType type2;
    [SerializeField] private float height;
    [SerializeField] private float weight;
    
    [SerializeField] private AbillityName[] abilities;
    [SerializeField] private AbillityName[] hiddenAbilities;

    [SerializeField] private int catchRate;
    [SerializeField] private int baseFriendship;
    [SerializeField] private int baseExp;
    [SerializeField] private int growthRate;
    [SerializeField] private GrowthRate growthRateData;
    
    [SerializeField] private List<EggGroup> eggGroups;
    [SerializeField] private bool genderless;
    [SerializeField] private float maleRatio;
    [SerializeField] private float femaleRatio;
    [SerializeField] private int eggCycles;

    [SerializeField] private int baseHp;
    [SerializeField] private int baseAttack;
    [SerializeField] private int baseDefense;
    [SerializeField] private int baseSpecialAttack;
    [SerializeField] private int baseSpecialDefense;
    [SerializeField] private int baseSpeed;

    //TODO: add evolutions
    
    [SerializeField] private List<Move> levelUpMoves;
    [SerializeField] private List<Move> tmMoves;
    [SerializeField] private List<Move> eggMoves;
    [SerializeField] private List<Move> tutorMoves;
    
    [SerializeField] private Sprite frontSprite;
    [SerializeField] private Sprite backSprite;
    [SerializeField] private Sprite menuSprite;
    [SerializeField] private Sprite shinyFrontSprite;
    [SerializeField] private Sprite shinyBackSprite;
    [SerializeField] private Sprite shinyMenuSprite;
    
    //public LocalizationAsset PokemonName => pokemonName;
    public int PokedexNumber => pokedexNumber;
    //public LocalizationAsset Entry => entry;
    public PokemonType Type1 => type1;
    public PokemonType Type2 => type2;
    public float Height => height;
    public float Weight => weight;
    public AbillityName[] Abilities => abilities;
    public AbillityName[] HiddenAbilities => hiddenAbilities;
    public int CatchRate => catchRate;
    public int BaseFriendship => baseFriendship;
    public int BaseExp => baseExp;
    public int GrowthRate => growthRate;
    public GrowthRate GrowthRateData => growthRateData;
    public List<EggGroup> EggGroups => eggGroups;
    public bool Genderless => genderless;
    public float MaleRatio => maleRatio;
    public float FemaleRatio => femaleRatio;
    public int EggCycles => eggCycles;
    public int BaseHp => baseHp;
    public int BaseAttack => baseAttack;
    public int BaseDefense => baseDefense;
    public int BaseSpecialAttack => baseSpecialAttack;
    public int BaseSpecialDefense => baseSpecialDefense;
    public int BaseSpeed => baseSpeed;
    public int GetBaseStat(Stat stat)
    {
        switch (stat)
        {
            case Stat.Hp:
                return baseHp;
            case Stat.Attack:
                return baseAttack;
            case Stat.Defense:
                return baseDefense;
            case Stat.SpecialAttack:
                return baseSpecialAttack;
            case Stat.SpecialDefense:
                return baseSpecialDefense;
            case Stat.Speed:
                return baseSpeed;
            default:
                return 0;
        }
    }
    public List<Move> LevelUpMoves => levelUpMoves;
    public List<Move> TmMoves => tmMoves;
    public List<Move> EggMoves => eggMoves;
    public List<Move> TutorMoves => tutorMoves;
    public Sprite FrontSprite => frontSprite;
    public Sprite BackSprite => backSprite;
    public Sprite MenuSprite => menuSprite;
    public Sprite ShinyFrontSprite => shinyFrontSprite;
    public Sprite ShinyBackSprite => shinyBackSprite;
    public Sprite ShinyMenuSprite => shinyMenuSprite;

}
