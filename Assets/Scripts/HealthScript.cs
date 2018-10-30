using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour {

    private float fillAmount;
    [SerializeField]
    private Image Player1HP;
    
  
	// Use this for initialization
    
	void Start () {
      
	}
	
	// Update is called once per frame
	void Update () {
        fillAmount = (float)PlayerScript.health / 100;
        Player1HP.fillAmount = fillAmount;
	}
}
