using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card_view : MonoBehaviour {
    public IcardGOcont cardGOcont;
    public base_field base_field1;
    public enum card_states { unknown, in_hand, on_field, ready2attack }
    public card_states card_state;
    // Use this for initialization
    card card1;
    //card_digit_view attack_prop;
    GameObject attack_spr;
    GameObject health_spr;
    GameObject mana_spr;
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
        remove_mana_cost();

    }

    public void add_mana_cost()
    {
        mana_spr = new GameObject();
        var mana_dv = mana_spr.AddComponent<card_digit_view>();
        mana_dv.attach2card(this.gameObject, card1.mana_cost);
        mana_spr.transform.localPosition = new Vector3(-0.6f, 1, 0);

    }
    public void remove_mana_cost()
    {
        if (mana_spr) GameObject.Destroy(mana_spr);
    }

    public void refresh_attack_health()
    {
        if (attack_spr) GameObject.Destroy(attack_spr);
        attack_spr = new GameObject();
        var attack_prop = attack_spr.AddComponent<card_digit_view>();
        attack_prop.attach2card(this.gameObject, card1.current_attack);
        //attack_spr.transform.position = new Vector3(-0.6f, -1, 0);
        attack_spr.transform.localPosition = new Vector3(-0.6f, -1, 0);

        if (health_spr) GameObject.Destroy(health_spr);
        health_spr = new GameObject();
        var health_prop = health_spr.AddComponent<card_digit_view>();
        health_prop.attach2card(this.gameObject, card1.current_health);
        //health_spr.transform.position = new Vector3(0.6f, -1, 0);
        health_spr.transform.localPosition = new Vector3(0.6f, -1, 0);
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
