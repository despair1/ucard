using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.EventSystems;

public class drag_handler : MonoBehaviour, IBeginDragHandler , IDragHandler
{

    // Use this for initialization
    BoxCollider2D bxc2d;
	void Start () {
        Debug.Log("on start");
        bxc2d = gameObject.GetComponent<BoxCollider2D>();
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("on update");
		
	}

    public void OnBeginDrag(PointerEventData ed)
    {
        Debug.Log("on begind drag");
        bxc2d.enabled = false;
    }

    public void OnDrag( PointerEventData ed)
    {
        //Debug.Log(" on drag ");
        //
        Vector3 v= Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, 0));
        v.z = 0;
        this.transform.position = v;
    }
}
