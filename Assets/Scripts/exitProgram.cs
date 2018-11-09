using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitProgram : MonoBehaviour
{
    //instantiates game objects- cursors for player one and player two
    private GameObject player1;
    private GameObject player2;
    //Instantiates booleans that determine if the players have entered the BoxCollider2D
    private bool p1entered;
    private bool p2entered;

    // Use this for initialization
    void Start()
    {
        //assigns the cursors in the game to the game objects instantiated above
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");
    }


    //Calls the code every frame
    void Update()
    {

        //Checks if player one's a button is pressed & if player 2 has entered the BoxCollider2D
        if (Input.GetButton("P1AButton") && p1entered)
        {
            //calls method to exit game
            QuitGame();
        }
        //Checks if player two's a button is pressed & if player 2 has entered the BoxCollider2D
        if (Input.GetButton("P2AButton") && p2entered)
        {
            //calls method to exit scene
            QuitGame();
        }
    }


    //Checks if the box collider is triggered and stays in code until it is no longer true
    private void OnTriggerEnter2D(Collider2D coll)
    {
        //Checks if the game object colliding with the button is player one's cursor
        if (coll.gameObject == player1)
        {
            //Tells the Script that Player 1 has entered the BoxCollider2D
            p1entered = true;
        }

        //Checks if the game object colliding with the button is player two's cursor
        if (coll.gameObject == player2)
        {
            //Tells the script that Player 2 has entered the BoxCollider2D      
            p2entered = true;
        }
    }

    private void OnTriggerExit(Collider coll)
    {
        //Checks if the game object colliding with the button is player one's cursor
        if (coll.gameObject == player1)
        {
            //Tells the Script that Player 1 has entered the BoxCollider2D
            p1entered = false;
        }
        //Checks if the game object colliding with the button is player two's cursor
        else if (coll.gameObject == player2)
        {
            //Tells the Script that Player 2 has entered the BoxCollider2D
            p2entered = false;
        }
    }
    //method to exit program
    public void QuitGame()
    {
        //exits program
        Application.Quit();
    }
}
   

