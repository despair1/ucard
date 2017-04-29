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
	
    public base_field get_free_field(card.card_owner owner=card.card_owner.enemy,bool busy=false)
    {
        List<GameObject> t;
        if (owner == card.card_owner.enemy) t = enemy_fields;
        else t = player_fields;
        foreach (GameObject field in t)
        {
            base_field bf = field.GetComponent<base_field>();
            if ((!bf.check_card())^busy) return bf;

        }
        return null;
    }
	// Update is called once per frame
	void Update () {
		
	}
}
