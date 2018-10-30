using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitProgram : MonoBehaviour {
    private GameObject player1;
    private GameObject player2;

    // Use this for initialization
    void Start()
    {
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");
    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        Debug.Log("Entered");
        if (Input.GetButton("P1AButton"))
        {
            Debug.Log("A Button");
            if (coll.gameObject == player1)
            {
                QuitGame();
            }
        }
        if (Input.GetButton("P2AButton"))
        {
            if (coll.gameObject == player2)
            {
                QuitGame();
            }
        }
    }
    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //just to check if it's working.
    }


}
    
   

