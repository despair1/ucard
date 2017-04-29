using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player_field : base_field,IDropHandler {
    //public bool has_card;
	// Use this for initialization
	void Start () {
        //Debug.Log(" start player field");
        //has_card = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDrop(PointerEventData ed)
    {
        if (! check_card() && drag_handler.draged_card.card_state ==
            drag_handler.card_states.in_hand)
        {
            Debug.Log(" on drop ");
            drag_handler.draged_card.base_field1 = this;
            place(drag_handler.draged_card.gameObject);
            drag_handler.draged_card.droped_on_player_field();
            //has_card = true;
        }
    }
}
