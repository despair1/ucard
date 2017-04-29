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
            
        }
        animated_attack_player aap= new animated_attack_player(this);
        aap.attack_player();
        //move_card_to_field();

    }
    override protected card_view add_view2card()
    {
        //Debug.Log(" in enemy add v2c 111");
        return card.AddComponent<enemy_card_handler>();
        
    }

    class animated_attack_player: IanimationEnd
    {
        enemy_hand eh1;
        base_field_cont bfc;
        base_field ocupied_enemy; // = bfc.get_free_field(global::card.card_owner.enemy, true);
        base_field ocupied_player; // = bfc.get_free_field(global::card.card_owner.player, true);
        //private IEnumerator corotine;

        public animated_attack_player(enemy_hand eh)
        {
            eh1 = eh;
            bfc = eh.gameObject.GetComponent<base_field_cont>();
            ocupied_enemy = bfc.get_free_field(global::card.card_owner.enemy, true);
            ocupied_player = bfc.get_free_field(global::card.card_owner.player, true);
        }
        public void attack_player()
        {

            if (ocupied_enemy && ocupied_player)
            {
                eh1.gameObject.GetComponent<combat>().start_corotine_animated_attack(
                    ocupied_enemy.check_card(), ocupied_player.check_card(), this);
                

            }
            else finalize();
        }
        public void end()
        {
            eh1.gameObject.GetComponent<combat>().card2card(
                    ocupied_enemy.check_card(), ocupied_player.check_card());
            finalize();
        }
        void finalize()
        {
            eh1.move_card_to_field();

        }


    }

    

    public void end()
    {

    }

    void move_card_to_field()
    {
        foreach ( var card in cards_in_hand ) {
            if (Random.Range(0, 5) < 1)
            {
                //enemy_field free_enemy_field = enemy_field.get_free_enemy_field();
                base_field free_enemy_field = this.gameObject.GetComponent<base_field_cont>().get_free_field();
                if (free_enemy_field)
                {
                    //cards_in_hand.Remove(card);
                    card.GetComponent<card_view>().move2field(free_enemy_field);
                    //card.GetComponent<card_view>().cardGOcont.remove_from_cont(card);
                    /*if (!card.GetComponent<enemy_card_handler>())
                    {
                        Debug.Log("0 ref");
                    }*/
                    //card.GetComponent<enemy_card_handler>().go_field();
                    //free_enemy_field.take_card();


                    //enemy_card_handler card = enemy_card_handler.get_random_card_from_hand();
                    //card.transform.position = free_enemy_field.gameObject.transform.position;
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
