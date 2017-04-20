﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour {
    Sprite s1;
    SpriteRenderer sr1;
    GameObject card;
    class position
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
    position p1=new position(-4,-3.5,0.7);
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
            card = new GameObject("card");
            s1 = Resources.Load<Sprite>("cards/boss_1");
            //s1 = Resources.Load<Sprite>("boss_1");
            sr1 = card.AddComponent<SpriteRenderer>();
            sr1.sprite = s1;
            sr1.transform.position = new Vector3(p1.begin_x+p1.card_count*p1.offset,
                p1.begin_y, 0);
            p1.card_count++;

        }

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}