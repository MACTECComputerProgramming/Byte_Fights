using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    //instantiates game objects - cursors for player one and player two
    private GameObject player1;
    private GameObject player2;

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
        //log allows us to make sure the game is working
        Debug.Log("Entered");

        //Checks if Player One's A button is pressed.
        if (Input.GetButton("P1AButton"))
        {
            //Log placed to ensure the script was working
            Debug.Log("A Button");
            //Checks if the object colliding with the button is player one's cursor
            if (coll.gameObject == player1)
            {
                //loads the Character Select scene
                SceneManager.LoadScene("Character_Select");
            }
        }
        //Checks if Player Two's A button is pressed
        if (Input.GetButton("P2AButton"))
        {
            // Checks if the object colliding with the button is player two's cursor
            if (coll.gameObject == player2)
            {
                //loads the Character Select scene
                SceneManager.LoadScene("Character_Select");
            }
        }
    }
}