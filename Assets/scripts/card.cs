using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card : MonoBehaviour {
    public enum card_owner {player,enemy };
    public card_owner owner;

    GameObject attack_digit_view;
    SpriteRenderer attack_digit_sprite = null;
    System.Nullable<int> attack = null;
    GameObject hand_obj;

    int base_attack;
    int base_health;
    public int current_attack;
    public int current_health;

	// Use this for initialization
	void Start () {
        /*
        hand_obj = GameObject.Find("hand_obj");
        attack_digit_sprite = this.gameObject.AddComponent<SpriteRenderer>();
        attack_digit_sprite.sortingOrder = 1;
        attack_digit_sprite.sprite = hand_obj.GetComponent<digits>().get_digit_sprite(3);
		*/
	}
    public void set_property(int _base_attack, int _base_health, card_owner _owner)
    {
        owner = _owner;
        current_attack = base_attack = _base_attack;
        current_health = base_health = _base_health;

    }
    public void set_attack_digit(int dig)
    {


    }
	
	// Update is called once per frame
	void Update () {
		
	}
    /*public void set_owner(card_owner card_owner1)
    {
        owner = card_owner1;
    }*/
}
