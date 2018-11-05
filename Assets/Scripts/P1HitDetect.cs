using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1HitDetect : MonoBehaviour {

    public PlayerScript player1;
	// Use this for initialization
	void Start () {
        player1 = FindObjectOfType<PlayerScript>();
        if(PlayerInfo.Player1char == "Pepe")
        {
           //this.GetComponent<Transform>().localPosition = new Vector2(7.15f, -0.08f);
        }
        if(PlayerInfo.Player1char == "Wick")
        {
            //this.GetComponent<Transform>().localPosition = new Vector2(3.15f, 1.81f);
        }
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
                p2PlayerScript.anim.SetFloat("Stunned", .3f);
            }
        }
    }
}
