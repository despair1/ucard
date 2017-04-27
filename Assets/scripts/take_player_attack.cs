using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class take_player_attack : MonoBehaviour, IDropHandler 
{

	// Use this for initialization
	void Start () {
        Debug.Log("take drag started");
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDrop(PointerEventData ed)
    {

        Debug.Log("take drag dropped");
        if ( drag_handler.draged_card.card_state == drag_handler.card_states.ready2attack)
        {
            Debug.Log("ready2attack");
        }
    }
}
