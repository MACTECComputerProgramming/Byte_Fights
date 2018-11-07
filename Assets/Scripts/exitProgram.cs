using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitProgram : MonoBehaviour {
    //instantiates game objects- cursors for player one and player two
    private GameObject player1;
    private GameObject player2;
    private bool p1entered;
    private bool p2entered;

    // Use this for initialization
    void Start()
    {
        //assigns the cursors in the game to the game objects instantiated above
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");
    }

    private void Update()
    {
        //Checks if player one's a button is pressed
        if (Input.GetButton("P1AButton"))
        {
           

                //calls method to exit game
                QuitGame();
            
        }
        //Checks if player two's a button is pressed
        if (Input.GetButton("P2AButton"))
        { 
                //calls method to exit scene
                QuitGame();
        
        }
    }
    //Checks if the box collider is triggered and stays in code until it is no longer true
    private void OnTriggerStay2D(Collider2D coll)
    {
        //Checks if the game object colliding with the button is player one's cursor
        if (coll.gameObject == player1)
        {
            p1entered = true;
        }
        
  //Checks if the game object colliding with the button is player two's cursor
            if (coll.gameObject == player2)
         {
            p2entered = true;
        }
    }
    //method to exit program
    public void QuitGame()
    {
        //exits program
        Application.Quit();
        Debug.Log("Game is exiting");
        //just to check if it's working.
    }


}
    
   

