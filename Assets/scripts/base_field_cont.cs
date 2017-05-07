using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class base_field_cont : MonoBehaviour {
    List<GameObject> enemy_fields=new List<GameObject>();
    List<GameObject> player_fields=new List<GameObject>();
	// Use this for initialization
	void Start () {

        foreach( var go in GameObject.FindGameObjectsWithTag("enemy_field"))
        {
            enemy_fields.Add(go);
        }
        foreach (var go in GameObject.FindGameObjectsWithTag("player_field"))
            player_fields.Add(go);
		
	}

    public void set_player_ready_attack()
    {
        foreach(var field in player_fields)
        {
            GameObject card = field.GetComponent<base_field>().check_card();
            if(card)
            {
                card.GetComponent<drag_handler>().card_state = drag_handler.card_states.ready2attack;
            }
        }
    }
    public void set_enemy_ready_attack()
    {
        foreach (var field in enemy_fields)
        {
            GameObject card = field.GetComponent<base_field>().check_card();
            if (card)
            {
                card.GetComponent<card_view>().card_state = drag_handler.card_states.ready2attack;
            }
        }
    }

    public base_field get_free_field(card.card_owner owner=card.card_owner.enemy)
    {
        List<GameObject> t;
        if (owner == card.card_owner.enemy) t = enemy_fields;
        else t = player_fields;
        foreach (GameObject field in t)
        {
            base_field bf = field.GetComponent<base_field>();
            if (!bf.check_card() ) return bf;
        }
        return null;
    }
    public base_field get_occupied_field(card.card_owner owner = card.card_owner.enemy, 
        drag_handler.card_states cardState = drag_handler.card_states.unknown)
    {
        List<GameObject> t;
        if (owner == card.card_owner.enemy) t = enemy_fields;
        else t = player_fields;
        foreach (GameObject field in t)
        {
            base_field bf = field.GetComponent<base_field>();
            GameObject card1 = bf.check_card();
            if (card1)
            {
                if (cardState == drag_handler.card_states.unknown) return bf;
                if (card1.GetComponent<drag_handler>().card_state == cardState) return bf;
            }
            
        }
        return null;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
