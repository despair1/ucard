using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card_view : MonoBehaviour {
    public IcardGOcont cardGOcont;
    public base_field base_field1;
    // Use this for initialization
    card card1;
    card_digit_view attack_prop;
    private void Awake()
    {
        card1 = this.gameObject.GetComponent<card>();
    }
    void Start () {
        
		
	}

    public void move2field(base_field base_field)
    {
        this.base_field1 = base_field;
        base_field.place(this.gameObject);
        this.transform.position = base_field.transform.position;
        cardGOcont.remove_from_cont(this.gameObject);

    }

    public void init_prop()
    {
        GameObject attack_spr = new GameObject();
        attack_prop = attack_spr.AddComponent<card_digit_view>();
        attack_prop.attach2card(this.gameObject, card1.current_attack);
        attack_spr.transform.position = new Vector3(-0.6f, -1, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
