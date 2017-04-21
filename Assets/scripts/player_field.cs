using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class player_field : MonoBehaviour,IDropHandler {

	// Use this for initialization
	void Start () {
        Debug.Log(" start player field");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void OnDrop(PointerEventData ed)
    {
        Debug.Log(" on drop ");
    }
}
