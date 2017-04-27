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
}
