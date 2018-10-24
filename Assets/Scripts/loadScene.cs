using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {
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

    private void OnTriggerEnter(Collider coll) 
    {
            if(Input.GetButton("P1AButton"))
            {
                SceneManager.LoadScene("Character_Select");
            }
            else if (Input.GetButton("P2AButton"))
            {
                SceneManager.LoadScene("Character_Select");
            }
        
    }
   
	
		
	
}
