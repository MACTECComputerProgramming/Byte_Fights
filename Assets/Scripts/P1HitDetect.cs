using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1HitDetect : MonoBehaviour {

    static public float p2BlockWait;
	// Use this for initialization
	void Start() { 
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    private void OnTriggerEnter2D(Collider2D col)
    {
        
        if (col.gameObject.name.Equals("Player 2"))
        {
            
            if (p2PlayerScript.anim.GetBool("Block") == false)
            {

                p2PlayerScript.health -= PlayerScript.damage;

                p2PlayerScript.anim.SetFloat("Stunned", .3f);
            }
            else
            {
                p2PlayerScript.anim.SetBool("Block", false);

                p2BlockWait = 2;
            }
        }
    }
}
