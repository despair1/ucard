using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hand : MonoBehaviour,IcardGOcont {

    protected Sprite s1;
    protected SpriteRenderer sr1;
    protected GameObject card;
    protected List<GameObject> cards_in_hand = new List<GameObject>();

    Image im1;
    BoxCollider2D bxc2d;
    protected class position
    {
        public float original_x;
        public float begin_x;
        public float begin_y;
        public float offset;
        public int card_count;


        public position(double x,double y,double ofst)
        {
            
            begin_x = (float)x ;
            original_x = (float)x;
            begin_y = (float)y;
            offset = (float)ofst;
            card_count = 0;
        }
    }
    protected position p1=new position(0,-3.5,1.4);

    protected class sprite_res_names
    {
        static string[] names = { "cards/boss_1", "cards/anchutka", "cards/mara", "cards/babay" };
        static public string get_name()
        {
            return names[Random.Range(0, names.Length)];
        }
    }
	// Use this for initialization
	void Start () {
        /*s1 = Resources.Load<Sprite>("cards/boss_1");
        //s1 = Resources.Load<Sprite>("boss_1");
        sr1 = gameObject.AddComponent<SpriteRenderer>();
        sr1.sprite = s1;
        sr1.transform.position = new Vector3(-2, -4, 0);
        //Instantiate(s1);*/
        Debug.Log("CREATING HAND OBJ");
	}

    public void OnNextMove() // player move
    {
        if (cards_in_hand.Count<9)
        {
            create_card_gameobj("player_card",global::card.card_owner.player);
            //card.AddComponent<drag_handler>();
        }
        this.gameObject.GetComponent<player_field_cont>().set_ready2attack();

    }
    protected void create_card_gameobj(string card_object_name,card.card_owner card_owner)
    {
        card = new GameObject(card_object_name);
        s1 = Resources.Load<Sprite>(sprite_res_names.get_name());
        sr1 = card.AddComponent<SpriteRenderer>();
        card card_logic = card.AddComponent<card>();
        card_logic.owner = card_owner;
        sr1.sprite = s1;
        card.AddComponent<BoxCollider2D>();
        // unic cont for player\enemy hand
        //cards_in_hand.Add(card);
        card_view cv = add_view2card();
        cv.cardGOcont = this;
        cv.cardGOcont.add2cont(card);
        set_new_hand_positions();

    }

    protected card_view add_view2card()
    {
        //var dh=card.AddComponent<drag_handler>();
        return card.AddComponent<drag_handler>();
        //dh.cardGOcont = this;
        //dh.cardGOcont.add2cont(card);
    }

    public void set_new_hand_positions()
    {
        float begin_x = p1.original_x - cards_in_hand.Count * p1.offset/2;
        int card_count = 0;
        foreach(var card in cards_in_hand)
        {
            card.transform.position = new Vector3(begin_x + p1.offset * card_count,
                p1.begin_y, 0);
            card_count++;
        }
    }

    public void remove_card_from_hand(GameObject card)
    {
        cards_in_hand.Remove(card);
    }

    public void add2cont(GameObject card)
    {
        cards_in_hand.Add(card);

    }

    public void remove_from_cont(GameObject card)
    {

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
