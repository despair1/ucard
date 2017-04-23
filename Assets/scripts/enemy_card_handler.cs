using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class enemy_card_handler : MonoBehaviour, IDropHandler
{

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void OnDrop(PointerEventData ed)
    {
        /*
        if (!has_card && drag_handler.draged_card.card_state ==
            drag_handler.card_states.in_hand)
        {
            Debug.Log(" on drop ");
            drag_handler.draged_card.droped(this.transform.position);
            has_card = true;
        }*/
        Debug.Log(" enemy card: droped by player");
    }
}
