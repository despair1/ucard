using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_field_cont : MonoBehaviour {


    protected List<GameObject> cards_in_field = new List<GameObject>();
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void add_card2field(GameObject card)
    {
        cards_in_field.Add(card);
    }

    public void set_ready2attack()
    {
        foreach(var card in cards_in_field)
        {
            card.GetComponent<drag_handler>().card_state = drag_handler.card_states.ready2attack;
        }
    }
    public void remove_from_field(GameObject card)
    {
        cards_in_field.Remove(card);
        var dh = card.GetComponent<drag_handler>();
        dh.underlying_player_field.has_card=false;
        //pf.has_card = false;
        dh.underlying_player_field = null;

    }
}
