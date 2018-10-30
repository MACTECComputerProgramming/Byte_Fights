using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetectP1 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        Debug.Log("Trigger");
        if (col.gameObject.name.Equals("Player 2"))
        {
            Debug.Log("if");
            PlayerScript.health -= .1;
        }
    }
}
