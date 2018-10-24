using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class nextScene : MonoBehaviour {
    private GameObject player1;
    private GameObject player2;
    
	
	void Start () {
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");

	}
	
	
	void Update () {
		
	}

    private void OnTriggerStay(Collider coll)
    {
        if (coll.gameObject == player1)
        {
            Debug.Log("Working");
            if (Input.GetButton("P1AButton"))
            {
                Debug.Log("k");
                SceneManager.LoadScene("Character_Select");
            }
            else if (Input.GetButton("P2AButton"))
            {
                SceneManager.LoadScene("Character_Select");
            }
        }
    }
}
