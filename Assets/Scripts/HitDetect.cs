using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetect : MonoBehaviour {

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
            if (PlayerScript.anim.GetBool("Block") == false)
            {
                p2PlayerScript.health -= PlayerScript.damage;
            }
        }
        if(col.gameObject.name.Equals("Player 1"))
        {
            if (p2PlayerScript.anim.GetBool("Block") == false)
            {
                PlayerScript.health -= p2PlayerScript.damage;
            }
        }
    }
}
