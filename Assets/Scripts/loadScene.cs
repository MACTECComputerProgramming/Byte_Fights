using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    //instantiates game objects - cursors for player one and player two
    private GameObject player1;
    private GameObject player2;
    //instantiates the player entered bools that are true or false depending on if the player is within the BoxCollider2D
    private bool p1entered;
    private bool p2entered;

    //Initialization when the object is generated within the scene
    void Start()
    { 
        // finds the cursors in the game and assigns them to the game objects
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");
    }

    // Update is called once per frame
    void Update()
    {
        
        //Checks if Player One's A button is pressed & if player 1 has entered the BoxCollider2D
        if (Input.GetButton("P1AButton") && p1entered)
        {
            //loads the Character Select scene
            SceneManager.LoadScene("Character_Select");
        }

        //Checks if Player Two's A button is pressed & if player 2 has entered the BoxCollider2D
        if (Input.GetButton("P2AButton") && p2entered)
        {
           //loads the Character Select scene
           SceneManager.LoadScene("Character_Select");
        }
    }

    //detects when the box collider is triggered
    private void OnTriggerEnter2D(Collider2D coll)
    {
        //Checks if the object colliding with the button is player one's cursor
        if(coll.gameObject == player1)
        {
            //Tells the script that player1 has entered the BoxCollider2D
            p1entered = true;
        }
        // Checks if the object colliding with the button is player two's cursor
        else if (coll.gameObject == player2)
        {
            //Tells the script that player2 has entered the BoxCollider2D
            p2entered = true;
        }

    }
    private void OnTriggerExit2D(Collider2D coll)
    {
        //Checks if the object colliding with the button is player one's cursor
        if (coll.gameObject == player1)
        {
            //Tells the script that player1 has left the BoxCollider2D
            p1entered = false;
        }
        // Checks if the object colliding with the button is player two's cursor
        if (coll.gameObject == player2)
        {
            //Tells the script that player2 has left the BoxCollider2D
            p2entered = false;
        }
    }
}