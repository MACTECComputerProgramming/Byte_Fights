using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FightController : MonoBehaviour {

	// Use this for initialization
	void Start () {
        if (PlayerInfo.Player1char == "Pepe")
        {
            GameObject.Find("Player1Pepe").SetActive(false);
        }
        if (PlayerInfo.Player2char == "Pepe")
        {
            GameObject.Find("Player2Pepe").SetActive(true);
        }
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
