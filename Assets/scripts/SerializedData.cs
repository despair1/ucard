using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class CardDescription
{
    public string png_file_name;
    public int attack;
    public int health;
    public int mana_cost;
}

[System.Serializable]
public class CardList
{
    public CardDescription[] cardList;
}

