using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_hand : hand {


    
    
    // Use this for initialization
    void Start () {
        p1 = new position(0, 3.5, 1.4);

    }
    new public void OnNextMove()
    {
        if (cards_in_hand.Count < 9)
        {
            create_card_gameobj("enemy_card",global::card.card_owner.enemy);
            
            //card.AddComponent<enemy_card_handler>();

            //cards_in_hand.Add(card);
            move_card_to_field();
        }
        

    }
    override protected card_view add_view2card()
    {
        //Debug.Log(" in enemy add v2c 111");
        return card.AddComponent<enemy_card_handler>();
        
    }

    void move_card_to_field()
    {
        foreach ( var card in cards_in_hand ) {
            if (Random.Range(0, 5) < 1)
            {
                enemy_field free_enemy_field = enemy_field.get_free_enemy_field();
                if (free_enemy_field)
                {
                    //cards_in_hand.Remove(card);
                    card.GetComponent<card_view>().cardGOcont.remove_from_cont(card);
                    /*if (!card.GetComponent<enemy_card_handler>())
                    {
                        Debug.Log("0 ref");
                    }*/
                    card.GetComponent<enemy_card_handler>().go_field();
                    free_enemy_field.take_card();


                    //enemy_card_handler card = enemy_card_handler.get_random_card_from_hand();
                    card.transform.position = free_enemy_field.gameObject.transform.position;
                    //set_new_hand_positions();
                    card.AddComponent<take_player_attack>();
                }
                break;

            }
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
