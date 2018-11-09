using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2PlayerScript : MonoBehaviour
{
    //Instantiates the player's starting health and damage dealt
    static public double damage = 10;
    static public double health = 100;
    //Instatiates the in game player into the code to control
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
        // Retrieves the Player's Rigidbody
        theRB = GetComponent<Rigidbody2D>();
        //Checks if the player selected Pepe as their character
        if (PlayerInfo.Player2char == "Pepe")
        {
            //Checks if Player 1 has selected pepe also and changes player 2s color if so
            if (PlayerInfo.Player1char == "Pepe")
            {
                this.GetComponent<SpriteRenderer>().color = Color.green;
            }
            //Sets Damage to 20
            damage = 20;
            //resizes the player to needed sizes for Pepe
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -1.2f);
            this.transform.localScale = new Vector2(-.7f , .8f);
            this.GetComponent<Animator>().runtimeAnimatorController = Pepe;
        }
        else if (PlayerInfo.Player2char == "Wick")
        {
            //Checks if player 1 has selected wick then changes player 2s color if so
            if (PlayerInfo.Player1char == "Wick")
            {
                this.GetComponent<SpriteRenderer>().color = Color.green;
            }
            //Sets damage to 15 for Wick
            damage = 15;
            //Resizes the player to the needed sizes for Wick
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -.3f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(2.5f, 5);
            this.transform.localScale = new Vector2(1, 1.1f);
            this.GetComponent<Animator>().runtimeAnimatorController = Wick;
        }
        //Instantiates the animator of the current character selected
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    { 
        //Sets the player's movespeed to the input of the left Joystick horizontal
        float movespeed = 1;
        movespeed = movespeed * Input.GetAxis("p2LeftJoystickHorizontal");
        //Disables the player's controls when stunned
            if (anim.GetFloat("Stunned") <= 0)
            {
                //Disables movement while Punching
            if (!anim.GetBool("Punch"))
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
                //When the player presses the AButton this script runs
                if (Input.GetButton("P2AButton"))
                {
                    anim.SetBool("Punch", true);
                    theRB.velocity = new Vector2(0, 0);
                }
                else
                {
                    anim.SetBool("Punch", false);
                }
                //When the player presses the B Button and hasn't had their block broken recently
                if (Input.GetButton("P2BButton") && P1HitDetect.p2BlockWait <= 0)
                {
                    anim.SetBool("Block", true);
                }
                else
                {
                    //Sets a timer after their block recieves a hit
                    P1HitDetect.p2BlockWait -= Time.deltaTime;
                    anim.SetBool("Block", false);
                }
            }
            else
            {
                //Sets a timer for how long the player is stunned after being hit
                anim.SetFloat("Stunned", anim.GetFloat("Stunned") - Time.deltaTime);
            }
    }
}

