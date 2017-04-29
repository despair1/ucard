using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class base_field_cont : MonoBehaviour {
    List<GameObject> enemy_fields;
    List<GameObject> player_fields;
	// Use this for initialization
	void Start () {

        foreach( var go in GameObject.FindGameObjectsWithTag("enemy_field"))
        {
            enemy_fields.Add(go);
        }
        foreach (var go in GameObject.FindGameObjectsWithTag("player_field"))
            player_fields.Add(go);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
