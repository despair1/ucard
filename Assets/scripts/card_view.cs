using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class card_view : MonoBehaviour {
    public IcardGOcont cardGOcont;
    public base_field base_field1;
	// Use this for initialization
	void Start () {
		
	}

    public void move2field(base_field base_field)
    {
        this.base_field1 = base_field;
        base_field.place(this.gameObject);
        this.transform.position = base_field.transform.position;
        cardGOcont.remove_from_cont(this.gameObject);

    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
