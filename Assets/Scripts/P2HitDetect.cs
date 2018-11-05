using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2HitDetect : MonoBehaviour {

    public PlayerScript player1;
    // Use this for initialization
    void Start()
    {
        player1 = FindObjectOfType<PlayerScript>();
        if (PlayerInfo.Player2char == "Pepe")
        {
            //this.GetComponent<Transform>().localPosition = new Vector2(7.15f, -0.08f);
        }
        if (PlayerInfo.Player2char == "Wick")
        {
            //this.GetComponent<Transform>().localPosition = new Vector2(3.15f, 1.81f);
        }
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

                Vector2 hitDirection = player1.transform.position - col.transform.position;

                PlayerScript.anim.SetFloat("Stunned", .5f);
                //hitDirection = hitDirection.normalized;

                player1.Knockback(hitDirection);
            }
        }
    }
}
