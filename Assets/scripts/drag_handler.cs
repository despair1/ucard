using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.EventSystems;

public class drag_handler : MonoBehaviour, IBeginDragHandler , IDragHandler, IEndDragHandler
{
    public enum card_states { in_hand,on_field}
    public card_states card_state;
    public static drag_handler draged_card;

    BoxCollider2D bxc2d;
    Transform t;
    Vector3 pos;
    bool is_droped;
    
    
	void Start () {
        Debug.Log("on start");
        bxc2d = gameObject.GetComponent<BoxCollider2D>();
        card_state = card_states.in_hand;
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("on update");
		
	}

    public void OnBeginDrag(PointerEventData ed)
    {
        Debug.Log("on begind drag");
        bxc2d.enabled = false;
        pos = this.transform.position;
        draged_card = this;
        is_droped = false;
    }

    public void OnDrag( PointerEventData ed)
    {
        
        Vector3 v= Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        v.z = 0;
        this.transform.position = v;
    }

    public void OnEndDrag( PointerEventData ed)
    {
        
        if (!is_droped)
        {
            Debug.Log("on end drag");
            this.transform.position = pos;
            bxc2d.enabled = true;
        }

    }

    public void droped(Vector3 pos)
    {
        this.transform.position = pos;
        Debug.Log("card droped");
        is_droped = true;
        card_state = card_states.on_field;
        bxc2d.enabled = true;
    }
}
