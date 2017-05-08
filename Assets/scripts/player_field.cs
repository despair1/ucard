using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player_field : base_field,IDropHandler {
    //public bool has_card;
    // Use this for initialization
    ManaControl mc;
	void Start () {
        //Debug.Log(" start player field");
        //has_card = false;
        mc = GameObject.Find("hand_obj").GetComponent<ManaControl>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDrop(PointerEventData ed)
    {
        if (! check_card() && drag_handler.draged_card.card_state ==
            drag_handler.card_states.in_hand &&
            mc.take_mana(drag_handler.draged_card.GetComponent<card>().mana_cost))
        {
            Debug.Log(" on drop ");
            //drag_handler.draged_card.base_field1 = this;
            //place(drag_handler.draged_card.gameObject);
            drag_handler.draged_card.move2field(this);
            drag_handler.draged_card.droped_on_player_field();
            //has_card = true;
        }
    }
}
