using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PokemonBase : ScriptableObject
{
    public LocalizationAsset pokemonName;
    public int pokedexNumber;
    public LocalizationAsset entry;
    PokemonType type1;
    PokemonType type2;
    public float height;
    public float weight;
    
    //TODO: add abilities

    public int catchRate;
    public int baseFriendship;
    public int baseExp;
    public int growthRate;
    public GrowthRate growthRateData;
    
    public List<EggGroup> eggGroups;
    public bool genderless;
    public float maleRatio;
    public float femaleRatio;
    public int eggCycles;
    public int baseHp;
    public int baseAttack;
    public int baseDefense;
    public int baseSpAttack;
    public int baseSpDefense;
    public int baseSpeed;
    
    //TODO: add evolutions
    
    public List<Move> levelUpMoves;
    public List<Move> tmMoves;
    public List<Move> eggMoves;
    public List<Move> tutorMoves;
    
    public Sprite frontSprite;
    public Sprite backSprite;
    public Sprite menuSprite;
    public Sprite shinyFrontSprite;
    public Sprite shinyBackSprite;
    public Sprite shinyMenuSprite;
    
}
