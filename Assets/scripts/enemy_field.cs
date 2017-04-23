﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_field : MonoBehaviour {

    static List<enemy_field> enemy_fields = new List<enemy_field>();
    public static enemy_field get_free_enemy_field()
    {
        foreach(var ech in enemy_fields)
        {
            if (!ech.has_card) return ech;
        }
        return null;
    }
    bool has_card = false;
    // Use this for initialization
    void Start () {
        enemy_fields.Add(this);
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
