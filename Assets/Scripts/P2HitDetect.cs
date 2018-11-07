using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2HitDetect : MonoBehaviour {
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
        if (col.gameObject.name.Equals("Player 1"))
        {
            if (PlayerScript.anim.GetBool("Block") == false)
            {

                PlayerScript.health -= p2PlayerScript.damage;

                PlayerScript.anim.SetFloat("Stunned", .3f);
            }
            else
            {
                PlayerScript.anim.SetBool("Block", false);

                p1BlockWait = 2;
            }
        }
    }
}
