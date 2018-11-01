using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HitDetect : MonoBehaviour {

    public PlayerScript player1;
	// Use this for initialization
	void Start () {
        player1 = FindObjectOfType<PlayerScript>();
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
            if (p2PlayerScript.anim.GetBool("Block") == false)
            {
                Debug.Log("Hit");
                p2PlayerScript.health -= PlayerScript.damage;
                p2PlayerScript.anim.SetFloat("Stunned", 2);
            }
        }
        if(col.gameObject.name.Equals("Player 1"))
        {
            if (PlayerScript.anim.GetBool("Block") == false)
            {
                PlayerScript.health -= p2PlayerScript.damage;

                Vector2 hitDirection =  player1.transform.position - col.transform.position;

                PlayerScript.anim.SetFloat("Stunned", 2);
                //hitDirection = hitDirection.normalized;

                player1.Knockback(hitDirection);
            }
        }
    }
}
