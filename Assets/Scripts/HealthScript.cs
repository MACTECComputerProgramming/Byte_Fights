using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    private float P1fillAmount,P2fillAmount;
    [SerializeField]
    private Image Player1HP;
    [SerializeField]
    private Image Player2Hp;
    
  
	// Use this for initialization
    
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        P1fillAmount = (float)PlayerScript.health / 100;
        Player1HP.fillAmount = P1fillAmount;

        P2fillAmount = (float)p2PlayerScript.health / 100;
        Player2Hp.fillAmount = P2fillAmount;
	}
}
