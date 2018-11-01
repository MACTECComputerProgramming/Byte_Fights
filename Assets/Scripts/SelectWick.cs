﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SelectWick : MonoBehaviour {
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
        if (Input.GetButton("P1AButton"))
        {
            if (coll.gameObject == player1)
            {
                PlayerInfo.Player1char = "Wick";
            }
        }
        if (Input.GetButton("P2AButton"))
        {
            if (coll.gameObject == player2)
            {
                Debug.Log("P2Wick");
                PlayerInfo.Player2char = "Wick";
            }
        }
    }
}
