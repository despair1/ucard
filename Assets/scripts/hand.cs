using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hand : MonoBehaviour {
    Sprite s1;
    SpriteRenderer sr1;
	// Use this for initialization
	void Start () {
        s1 = Resources.Load<Sprite>("cards/boss_1");
        //s1 = Resources.Load<Sprite>("boss_1");
        sr1 = gameObject.AddComponent<SpriteRenderer>();
        sr1.sprite = s1;
        //Instantiate(s1);
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
