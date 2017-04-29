using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class combat : MonoBehaviour {
    //player_field_cont player_field_container_obj;
    //hand hand_obj;
    // Use this for initialization
    void Start () {
      //  player_field_container_obj = GameObject.Find("hand_obj").GetComponent<player_field_cont>();

    }

    // Update is called once per frame
    void Update () {
		
	}

    public void card2card(GameObject attacking_card, GameObject defending_card)
    {
        destroy_card(attacking_card);

    }
    void destroy_card(GameObject card)
    {
        if (card.GetComponent<card>().owner == global::card.card_owner.player)
        {
            //player_field_container_obj.remove_from_field(card);
            card.GetComponent<card_view>().base_field1.remove_card();
            Destroy(card);

        }
    }
}
