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
        destroy_card(defending_card);

    }
    public void start_corotine_animated_attack(GameObject attacking_card, GameObject defending_card,
        IanimationEnd anim_end)
    {
        IEnumerator corot = animated_card2card(attacking_card, defending_card,
        anim_end);
        StartCoroutine(corot);
    }


    public IEnumerator animated_card2card(GameObject attacking_card, GameObject defending_card,
        IanimationEnd anim_end)
    {
        float time_since_started = 0f;
        //bool end = false;
        while (true)
        {
            time_since_started += Time.deltaTime/5f;
            if (attacking_card.transform.position == defending_card.transform.position) break;
            attacking_card.transform.position = Vector3.Lerp(
                attacking_card.transform.position, defending_card.transform.position, time_since_started);
            yield return null;
        }
        anim_end.end();
    }
    void destroy_card(GameObject card)
    {
        //if (card.GetComponent<card>().owner == global::card.card_owner.player)
        {
            //player_field_container_obj.remove_from_field(card);
            card.GetComponent<card_view>().base_field1.remove_card();
            Destroy(card);

        }
    }
}
