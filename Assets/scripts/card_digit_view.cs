using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card_digit_view : MonoBehaviour {


    GameObject hand_obj1;
    SpriteRenderer spr_rend;
    // Use this for initialization
    //card_digit_view attack_prop;
	void Awake () {
        hand_obj1 = GameObject.Find("hand_obj");
		
	}

    public void attach2card(GameObject card1,int digit)
    {
        //hand_obj1 = GameObject.Find("hand_obj");
        //transform.parent = card1.transform;
        this.transform.parent = card1.transform;
        
        spr_rend = this.gameObject.AddComponent<SpriteRenderer>();
        spr_rend.sortingOrder = 1;
        spr_rend.sprite = hand_obj1.GetComponent<digits>().get_digit_sprite(digit);


    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
