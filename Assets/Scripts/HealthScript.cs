using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    public float P1fillAmount;
    
    public float P2fillAmount;

    public Image Player1HP;
   
    public Image Player2Hp;
    
  
	// Use this for initialization
    
	void Start () {
        Player1HP.fillAmount = 1;
        Player2Hp.fillAmount = 1;
	}
	
	// Update is called once per frame
	void Update () {
        P1fillAmount = (float)PlayerScript.health / 100;
        Player1HP.fillAmount = P1fillAmount;

        P2fillAmount = (float)p2PlayerScript.health / 100;
        Player2Hp.fillAmount = P2fillAmount;
	}
}
