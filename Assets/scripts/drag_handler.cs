﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.UI;
using UnityEngine.EventSystems;

public class drag_handler : MonoBehaviour, IBeginDragHandler , IDragHandler
{

	// Use this for initialization
	void Start () {
        Debug.Log("on start");
		
	}
	
	// Update is called once per frame
	void Update () {
        //Debug.Log("on update");
		
	}

    public void OnBeginDrag(PointerEventData ed)
    {
        Debug.Log("on begind drag");
    }

    public void OnDrag( PointerEventData ed)
    {
        Debug.Log(" on drag ");
        
    }
}
