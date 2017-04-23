using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_hand : hand {


    
    static List<GameObject> enemy_cards = new List<GameObject>();
    // Use this for initialization
    void Start () {
        p1 = new position(-4, 3.5, 1.4);

    }
    new public void OnNextMove()
    {
        if (p1.card_count < 9)
        {
            create_card_spite();
            
            card.AddComponent<enemy_card_handler>();

            enemy_cards.Add(card);
            move_card_to_field();
        }
        

    }

    void move_card_to_field()
    {
        if (p1.card_count % 2 == 0)
        {
            enemy_field ef = enemy_field.get_free_enemy_field();
            enemy_card_handler card = enemy_card_handler.get_random_card_from_hand();
            card.gameObject.transform.position = ef.gameObject.transform.position;

        }
    }


    // Update is called once per frame
    void Update () {
		
	}
}
