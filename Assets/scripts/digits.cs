using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class digits : MonoBehaviour {
    List<Sprite> digits_sprite_list = new List<Sprite>();
	// Use this for initialization
	void Start () {
        Debug.Log("creating digit sprites");
        foreach(Sprite spr in Resources.LoadAll<Sprite>("misc/digit_def"))
        {
            digits_sprite_list.Add(spr);
        }
        /*
        for (int i = 0; i < 10; i++)
        {
            digits_sprite_list.Add(Resources.Load<Sprite>("misc/digit_def_1" ));
        }*/
		
	}

    public Sprite get_digit_sprite(int num)
    {
        //return Resources.Load<Sprite>("misc/digit_def_0");
        return digits_sprite_list[num];
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
