using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2PlayerScript : MonoBehaviour
{


    static public double damage = 10;
    static public double health = 100;
    private Rigidbody2D theRB;
    public SpriteRenderer Player2;
    public RuntimeAnimatorController Pepe;
    public RuntimeAnimatorController Wick;
    static public Animator anim;


    public float knockBackForce;
    public float knockBackTime;
    private float knockBackCounter;

    // Use this for initialization
    void Start()
    {
        health = 100;
        theRB = GetComponent<Rigidbody2D>();
        if (PlayerInfo.Player2char == "Pepe")
        {
            if (PlayerInfo.Player1char == "Pepe")
            {
                this.GetComponent<SpriteRenderer>().color = Color.green;
            }
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -1.2f);
            this.transform.localScale = new Vector2(-.7f , .8f);
            this.GetComponent<Animator>().runtimeAnimatorController = Pepe;
        }
        else if (PlayerInfo.Player2char == "Wick")
        {
            if (PlayerInfo.Player1char == "Wick")
            {
                this.GetComponent<SpriteRenderer>().color = Color.green;
            }
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -.3f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(2.5f, 5);
            this.transform.localScale = new Vector2(1, 1.1f);
            this.GetComponent<Animator>().runtimeAnimatorController = Wick;
        }
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    { 
        float movespeed = 1;
        movespeed = movespeed * Input.GetAxis("p2LeftJoystickHorizontal");
        
            if (anim.GetFloat("Stunned") <= 0)
            {

            if (!anim.GetBool("Punch") || !anim.GetBool("Block"))
            {

                if (Input.GetAxis("p2LeftJoystickHorizontal") > 0)
                {
                    Player2.flipX = true;
                    theRB.velocity = new Vector2(movespeed, theRB.velocity.y);
                }
                else if (Input.GetAxis("p2LeftJoystickHorizontal") < 0)
                {
                    Player2.flipX = false;
                    theRB.velocity = new Vector2(movespeed, theRB.velocity.y);
                }
                else
                {
                    theRB.velocity = new Vector2(0, theRB.velocity.y);
                }
            }

                if (Input.GetButton("P2AButton"))
                {
                    anim.SetBool("Punch", true);
                    theRB.velocity = new Vector2(0, 0);
                }
                else
                {
                    anim.SetBool("Punch", false);
                }

                if (Input.GetButton("P2BButton") && P1HitDetect.p2BlockWait == 0)
                {
                    anim.SetBool("Block", true);
                    theRB.velocity = new Vector2(0, 0);
                }
                else
                {
                    P1HitDetect.p2BlockWait -= Time.deltaTime;
                    anim.SetBool("Block", false);
                }
            }
            else
            {
                anim.SetFloat("Stunned", anim.GetFloat("Stunned") - Time.deltaTime);
            }
    }
}

