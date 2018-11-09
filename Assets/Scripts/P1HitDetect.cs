using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1HitDetect : MonoBehaviour {
    //Instantiates the float used to set the delay between blocks
    static public float p2BlockWait;
	// Use this for initialization
	void Start() { 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        //Checks if it is colliding with Player 2
        if (col.gameObject.name.Equals("Player 2"))
        {
            // Checks if Player 2 is blocking
            if (p2PlayerScript.anim.GetBool("Block") == false)
            {
                //Deals player 2's damage to player 1
                p2PlayerScript.health -= PlayerScript.damage;
                //Breifly stuns player 1
                p2PlayerScript.anim.SetFloat("Stunned", .3f);
            }
            else
            {
                //Disables player 2's block after taking a hit
                p2PlayerScript.anim.SetBool("Block", false);

                p2BlockWait = 2;
            }
        }
    }
}
