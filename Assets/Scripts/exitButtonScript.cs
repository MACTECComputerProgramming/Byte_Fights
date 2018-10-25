using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitButtonScript : MonoBehaviour {
    private GameObject player1;
    private GameObject player2;


    void Start()
    {
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");

    }


    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        if (Input.GetButton("P1XButton"))
        {
            Debug.Log("Working");
            if (coll.gameObject == player1)
            {
                Application.Quit();
                Debug.Log("Game is exiting");
            }
        }
        else if (Input.GetButton("P2XButton"))
        {
            Debug.Log("Working 2");
            if (coll.gameObject == player2)
            {
                 Application.Quit();
                 Debug.Log("Game is exiting");
            }
        }



    }
    
}
    
   

