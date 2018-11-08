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
    public bool p1entered;
    public bool p2entered;
    

	// Use this for initialization
	void Start () {
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");
	}
	
	// Update is called once per frame
	void Update () {
                //Checks for Player 1's A Button Input
                if (Input.GetButton("P1AButton") && p1entered)
                {

                    //Sets their character to Pepe in Fight Scene
                    PlayerInfo.Player1char = "Pepe";
                    //Enables Icon for the player to see what character is selected
                    p1Pepe.enabled = true;
                    //Displays Character image
                    p1Pepe.sprite = feelsgood;
                }
                //Checks for Player 2's A Button Input 
            if (Input.GetButton("P2AButton") && p2entered)
            {                    
                    //Sets their character to Pepe in Fight Scene
                    PlayerInfo.Player2char = "Pepe";

                    //Enables Icon for the player to see what character is selected
                    p2Pepe.enabled = true;

                    //Displays Character image
                    p2Pepe.sprite = feelsgood;
            }
	}

    private void OnTriggerEnter2D(Collider2D coll)
    {
        //Checks if the Player has locked in with X
        if (PlayerInfo.P1lockedin == false)
        { 
            //Checks if object colliding is Player 1
            if (coll.gameObject == player1)
                {
                p1entered = true;
            }
        }
        //Checks if the Player has locked in with X
        if (PlayerInfo.P2lockedin == false)
        {
               //Checks if object colliding is Player 2
                if (coll.gameObject == player2)
                {
                p2entered = true;
            }
        }
    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        if (coll.gameObject == player2)
        {
            p2entered = false;
        }
        if (coll.gameObject == player1)
        {
            p1entered = false;
        }
    }
}
