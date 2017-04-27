using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class enemy_card_handler : MonoBehaviour, IDropHandler
{
    bool in_field = false;

    static List<enemy_card_handler> enemy_cards = new List<enemy_card_handler>();
    public static enemy_card_handler get_random_card_from_hand()
    {
        return enemy_cards[0];
    }
    public void go_field()
    {
        in_field = true;
    }
    /*public static enemy_card_handler get_free_enemy_field()
    {
        foreach(var ech in enemy_fields)
        {
            if (!ech.has_card) return ech;
        }
        return null;
    }
    bool has_card = false;*/

	// Use this for initialization
	void Start () {

        enemy_cards.Add(this);
		
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
        if (in_field)
        {
            Debug.Log(" enemy card: droped by player");
        }
    }
}
