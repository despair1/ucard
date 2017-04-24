using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class hand : MonoBehaviour {

    protected Sprite s1;
    protected SpriteRenderer sr1;
    protected GameObject card;

    Image im1;
    BoxCollider2D bxc2d;
    protected class position
    {
        public float begin_x;
        public float begin_y;
        public float offset;
        public int card_count;


        public position(double x,double y,double ofst)
        {
            begin_x = (float)x ;
            begin_y = (float)y;
            offset = (float)ofst;
            card_count = 0;
        }
    }
    protected position p1=new position(-4,-3.5,1.4);

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
	}

    public void OnNextMove()
    {
        if (p1.card_count<9)
        {
            create_card_spite("player_card");
            card.AddComponent<drag_handler>();
        }

    }
    protected void create_card_spite(string card_object_name)
    {
        card = new GameObject(card_object_name);
        //card.AddComponent<drag_handler>();
        //s1 = Resources.Load<Sprite>("cards/boss_1");
        s1 = Resources.Load<Sprite>(sprite_res_names.get_name());
        //s1 = Resources.Load<Sprite>("boss_1");
        sr1 = card.AddComponent<SpriteRenderer>();

        //im1 = card.AddComponent<Image>();
        //sr1.sprite = s1;
        sr1.sprite = s1;
        card.AddComponent<BoxCollider2D>();
        sr1.transform.position = new Vector3(p1.begin_x + p1.card_count * p1.offset,
            p1.begin_y, 0);
        p1.card_count++;

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
