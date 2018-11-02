using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectPepe : MonoBehaviour {
    private GameObject player1;
    private GameObject player2;
    public Image p1Pepe;
    public Image p2Pepe;
    public Sprite feelsgood;
    

	// Use this for initialization
	void Start () {
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");
	}
	
	// Update is called once per frame
	void Update () {
       
	}

    private void OnTriggerStay2D(Collider2D coll)
    {
        //Checks for Player 1's A Button Input
        if(Input.GetButton("P1AButton"))
        {

            //Checks if object colliding is Player 1
            if(coll.gameObject == player1)
            {
                //Sets their character to Pepe in Fight Scene
                PlayerInfo.Player1char = "Pepe";
                //Enables Icon for the player to see what character is selected
                p1Pepe.enabled = true;
                //Displays Character image
                p1Pepe.sprite = feelsgood;
            }
        }
        //Checks for Player 2's A Button Input
        if (Input.GetButton("P2AButton"))
        {
            //Checks if object colliding is Player 2
            if (coll.gameObject == player2)
            {
                //Sets their character to Pepe in Fight Scene
                PlayerInfo.Player2char = "Pepe";

                //Enables Icon for the player to see what character is selected
                p2Pepe.enabled = true;

                //Displays Character image
                p2Pepe.sprite = feelsgood;
            }
        }
    }
}
