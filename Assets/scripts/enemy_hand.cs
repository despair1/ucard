using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_hand : hand {


    
    static List<GameObject> enemy_cards_in_hand = new List<GameObject>();
    // Use this for initialization
    void Start () {
        p1 = new position(-4, 3.5, 1.4);

    }
    new public void OnNextMove()
    {
        if (p1.card_count < 9)
        {
            create_card_spite("enemy_card");
            
            card.AddComponent<enemy_card_handler>();

            enemy_cards_in_hand.Add(card);
            move_card_to_field();
        }
        

    }

    void move_card_to_field()
    {
        foreach ( var card in enemy_cards_in_hand ) {
            if (Random.Range(0, 5) < 1)
            {
                enemy_field free_enemy_field = enemy_field.get_free_enemy_field();
                if (free_enemy_field)
                {
                    enemy_cards_in_hand.Remove(card);
                    card.GetComponent<enemy_card_handler>().go_field();
                    free_enemy_field.take_card();


                    //enemy_card_handler card = enemy_card_handler.get_random_card_from_hand();
                    card.transform.position = free_enemy_field.gameObject.transform.position;
                }
                else break;

            }
        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
