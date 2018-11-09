using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2HitDetect : MonoBehaviour {
    //Instatiates the floate that will gain value when the player is hit while blocking
    static public float p1BlockWait;
    // Use this for initialization
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter2D(Collider2D col)
    {
        //Checks if it is colliding with Player 1
        if (col.gameObject.name.Equals("Player 1"))
        {
            //Checks if Player 1 is blocking
            if (PlayerScript.anim.GetBool("Block") == false)
            {
                //Deals player 2's damage to player 1
                PlayerScript.health -= p2PlayerScript.damage;
                //Breifly stuns player 1
                PlayerScript.anim.SetFloat("Stunned", .3f);
            }
            else
            {
                //Disables player 1's ability to block after being hit
                PlayerScript.anim.SetBool("Block", false);

                p1BlockWait = 2;
            }
        }
    }
}
