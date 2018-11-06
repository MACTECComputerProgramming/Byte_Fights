using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    //assigns floats aka amount of the health bar that's filled
    public float P1fillAmount;
    
    public float P2fillAmount;


    //assigns image on health bars
    public Image Player1HP;
   
    public Image Player2Hp;
    
  
	// Use this for initialization
    
	void Start () {
        //tells the bar to fill completely - 100% = 1
        Player1HP.fillAmount = 1;
        Player2Hp.fillAmount = 1;
	}
	
	// Update is called once per frame
	void Update () {
        //sets fill amount to percent of player one's health bar based on remaining health
        P1fillAmount = (float)PlayerScript.health / 100;
        Player1HP.fillAmount = P1fillAmount;

        //sets fill amount to percent of player two's health bar based on remaining health
        P2fillAmount = (float)p2PlayerScript.health / 100;
        Player2Hp.fillAmount = P2fillAmount;
	}
}
