using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitProgram : MonoBehaviour {
    //instantiates game objects- cursors for player one and player two
    private GameObject player1;
    private GameObject player2;

    // Use this for initialization
    void Start()
    {
        //assigns the cursors in the game to the game objects instantiated above
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");
    }

    //Checks if the box collider is triggered and stays in code until it is no longer true
    private void OnTriggerStay2D(Collider2D coll)
    {  
        //Checks if player one's a button is pressed
        if (Input.GetButton("P1AButton"))
        {
            //Checks if the game object colliding with the button is player one's cursor
            if (coll.gameObject == player1)
            {
                //calls method to exit game
                QuitGame();
            }
        }
        //Checks if player two's a button is pressed
        if (Input.GetButton("P2AButton"))
        {   //Checks if the game object colliding with the button is player two's cursor
            if (coll.gameObject == player2)
            {   
                //calls method to exit scene
                QuitGame();
            }
        }
    }
    //method to exit program
    public void QuitGame()
    {
        //exits program
        Application.Quit();
       
    }


}
    
   

