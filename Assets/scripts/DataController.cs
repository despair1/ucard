using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DataController : MonoBehaviour {

    // Use this for initialization
    public CardList cardList;
    private void Awake()
    {
        string json_card_list = System.IO.File.ReadAllText("card_list.txt");
        cardList = JsonUtility.FromJson<CardList>(json_card_list);
    }
    void Start () {
        
        CardDescription cd1=new CardDescription();
        cd1.attack = 1;
        cd1.health = 2;
        cd1.png_file_name = "lammerz";
        CardDescription cd2 = new CardDescription();
        cd2.attack = 2;
        cd2.health = 3;
        cd2.png_file_name = "quantuz";
        CardList cl = new CardList();
        cl.cardList = new CardDescription[] { cd1,cd2,cd1};
        string json1 = JsonUtility.ToJson(cl, true);
        System.IO.File.WriteAllText("test_json.txt", json1);
        

    }
    
	
	// Update is called once per frame
	void Update () {
		
	}
}
