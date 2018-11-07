﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    static public double damage = 10;
    static public double health = 100;
    static public Rigidbody2D theRB;
    public SpriteRenderer Player1;
    public RuntimeAnimatorController Pepe;
    public RuntimeAnimatorController Wick;
    static public Animator anim;

    // Use this for initialization
    void Start()
    {
        health = 100;
        theRB = GetComponent<Rigidbody2D>();
        if (PlayerInfo.Player1char == "Pepe")
        {
            Debug.Log("Pepe");
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -1.2f);
            this.transform.localScale = new Vector2(.7f, .8f);
            this.GetComponent<Animator>().runtimeAnimatorController = Pepe;
        }
        else if (PlayerInfo.Player1char == "Wick")
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -.3f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(2.5f, 5);
            this.transform.localScale = new Vector2(-1, 1.1f);
            this.GetComponent<Animator>().runtimeAnimatorController = Wick;
            
        }
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        float movespeed = 1;
        movespeed = movespeed * Input.GetAxis("LeftJoystickHorizontal");
        if ( anim.GetFloat("Stunned") <= 0)
        {

            if (!anim.GetBool("Punch") || !anim.GetBool("Block"))
            {
                
                if (Input.GetAxis("LeftJoystickHorizontal") == 1)
                {
                    Player1.flipX = false;
                    theRB.velocity = new Vector2(movespeed, theRB.velocity.y);
                }
                else if (Input.GetAxis("LeftJoystickHorizontal") == -1)
                {
                    Player1.flipX = true;
                    theRB.velocity = new Vector2(movespeed, theRB.velocity.y);
                }
                else
                {

                    theRB.velocity = new Vector2(0, theRB.velocity.y);
                }
            }

            if (Input.GetButton("P1AButton"))
            {
                anim.SetBool("Punch", true);
                theRB.velocity = new Vector2(0, 0);

            }
            else
            {
                anim.SetBool("Punch", false);
            }

            if (Input.GetButton("P1BButton") && P2HitDetect.p1BlockWait == 0)
            {
                anim.SetBool("Block", true);
                theRB.velocity = new Vector2(0, 0);
            }
            else
            {
                P2HitDetect.p1BlockWait -= Time.deltaTime;
                anim.SetBool("Block", false);
            }
        }
        else
        {
            anim.SetFloat("Stunned", anim.GetFloat("Stunned") - Time.deltaTime);
        }
    }
}
