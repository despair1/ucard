using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.EventSystems;

public class drag_handler : card_view, IBeginDragHandler , IDragHandler, IEndDragHandler
{
    
    public static drag_handler draged_card;

    BoxCollider2D bxc2d;
    //Transform t;
    Vector3 pos;
    bool is_droped_on_player_field;
    //hand hand_obj;
    //player_field_cont player_field_container_obj;
    public player_field underlying_player_field;
    
    
	void Start () {
        //Debug.Log("on start");
        bxc2d = gameObject.GetComponent<BoxCollider2D>();
        card_state = card_states.in_hand;
        //hand_obj = GameObject.Find("hand_obj").GetComponent<hand>();
       // player_field_container_obj = GameObject.Find("hand_obj").GetComponent<player_field_cont>();
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("on update");
		
	}

    public void OnBeginDrag(PointerEventData ed)
    {
        //Debug.Log("on begind drag");
        bxc2d.enabled = false;
        pos = this.transform.position;
        draged_card = this;
        is_droped_on_player_field = false;
    }

    public void OnDrag( PointerEventData ed)
    {
        
        Vector3 v= Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        v.z = 0;
        this.transform.position = v;
    }

    public void OnEndDrag( PointerEventData ed)
    {
        
        if (!is_droped_on_player_field)
        {
            //Debug.Log("on end drag");
            this.transform.position = pos;
            bxc2d.enabled = true;
        }

    }

    public void droped_on_player_field()
    {
        //this.transform.position = pl_field.transform.position;
        //this.transform.position = this.base_field1.transform.position;
        //pl_field.place(this.gameObject);
        //underlying_player_field = pl_field;
        //Debug.Log("card droped");
        is_droped_on_player_field = true;
        card_state = card_states.on_field;
        bxc2d.enabled = true;
        remove_mana_cost();
        //hand_obj.remove_card_from_hand(this.gameObject);
        //cardGOcont.remove_from_cont(this.gameObject);
        //player_field_container_obj.add_card2field(this.gameObject);
        //hand_obj.set_new_hand_positions();
    }
}
