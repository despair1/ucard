using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class base_field : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
    GameObject card1;
    public void place(GameObject card)
    {
        card1 = card;
    }
    public GameObject remove_card()
    {
        GameObject t = card1;
        card1 = null;
        return t;
    }
    public GameObject check_card()
    {
        return card1;
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
