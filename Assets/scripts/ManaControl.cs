using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ManaControl : MonoBehaviour {
    public Text text;
    // Use this for initialization
    int current_mana = 0;
    int base_mana = 0;
	void Start () {
        Debug.Log("mana control start");
        text.text = current_mana.ToString();
	}
    public void add_mana(int amount = 1)
    {
        base_mana += amount;
    }
    public void current2base()
    {
        current_mana = base_mana;
        text.text = current_mana.ToString();
    }
    public bool take_mana(int amount)
    {
        if (amount > current_mana) return false;
        current_mana -= amount;
        text.text = current_mana.ToString();
        return true;
    }
    public int check_current_mana()
    {
        return current_mana;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
