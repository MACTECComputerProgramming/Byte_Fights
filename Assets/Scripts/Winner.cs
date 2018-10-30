using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class Winner : MonoBehaviour {
    Text text;
	// Use this for initialization
	void Start () {

        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {

        if (HealthScript.Player2Hp.fillAmount == 0)
       {
           text.text = "Player 1 Wins ";
       }


	}
}
