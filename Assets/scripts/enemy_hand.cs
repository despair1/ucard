using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_hand : hand {


    position p1 = new position(-4, 3.5, 1.4);
    // Use this for initialization
    void Start () {
		
	}
    new public void OnNextMove()
    {
        if (p1.card_count < 9)
        {
            card = new GameObject("enemy_card");
            card.AddComponent<enemy_card_handler>();
            
            s1 = Resources.Load<Sprite>(sprite_res_names.get_name());
            
            sr1 = card.AddComponent<SpriteRenderer>();

            //im1 = card.AddComponent<Image>();
            //sr1.sprite = s1;
            sr1.sprite = s1;
            card.AddComponent<BoxCollider2D>();
            sr1.transform.position = new Vector3(p1.begin_x + p1.card_count * p1.offset,
                p1.begin_y, 0);
            p1.card_count++;

        }

    }
    // Update is called once per frame
    void Update () {
		
	}
}
