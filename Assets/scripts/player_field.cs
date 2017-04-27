using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player_field : MonoBehaviour,IDropHandler {
    bool has_card;
	// Use this for initialization
	void Start () {
        //Debug.Log(" start player field");
        has_card = false;
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDrop(PointerEventData ed)
    {
        if (!has_card && drag_handler.draged_card.card_state ==
            drag_handler.card_states.in_hand)
        {
            Debug.Log(" on drop ");
            drag_handler.draged_card.droped(this.transform.position);
            has_card = true;
        }
    }
}
