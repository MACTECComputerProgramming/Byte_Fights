using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    //instantiates game objects - cursors for player one and player two
    private GameObject player1;
    private GameObject player2;
    private bool p1entered;
    private bool p2entered;
    // Use this for initialization
    void Start()
    { // finds the cursors in the game and assigns them to the game objects
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");
    }

    // Update is called once per frame
    void Update()
    {


    }

    //detects when the box collider is triggered
    private void OnTriggerStay2D(Collider2D coll)
    {



        //Checks if Player One's A button is pressed.
        if (Input.GetButton("P1AButton"))
        {

            //Checks if the object colliding with the button is player one's cursor
            if (coll.gameObject == player1)
            {
                //loads the Character Select scene
                SceneManager.LoadScene("Character_Select");
            }
            //Checks if Player Two's A button is pressed
            if (Input.GetButton("P2AButton"))
            {
                //loads the Character Select scene
                SceneManager.LoadScene("Character_Select");
            }
        }
    }

    //detects when the box collider is triggered
    private void OnTriggerEnter2D(Collider2D coll)
    {
        //Checks if the object colliding with the button is player one's cursor
        if(coll.gameObject == player1)
        {
            p1entered = true;
        }
        // Checks if the object colliding with the button is player two's cursor
        else if (coll.gameObject == player2)
        {
            p2entered = true;
        }

    }
}