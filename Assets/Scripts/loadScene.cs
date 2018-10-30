using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour
{
    private GameObject player1;
    private GameObject player2;

    // Use this for initialization
    void Start()
    {
        player1 = GameObject.Find("P1Cursor");
        player2 = GameObject.Find("P2Cursor");
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnTriggerStay2D(Collider2D coll)
    {
        Debug.Log("Entered");
        if (Input.GetButton("P1AButton"))
        {
            Debug.Log("A Button");
            if (coll.gameObject == player1)
            {
                SceneManager.LoadScene("Character_Select");
            }
        }
        if (Input.GetButton("P2AButton"))
        {
            if (coll.gameObject == player2)
            {
                SceneManager.LoadScene("Character_Select");
            }
        }
    }
}