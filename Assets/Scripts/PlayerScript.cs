using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    //Instantiates the player's starting health and damage dealt
    static public double damage = 10;
    static public double health = 100;
    //Instatiates the in game player into the code to control
    static public Rigidbody2D theRB;
    public SpriteRenderer Player1;
    public RuntimeAnimatorController Pepe;
    public RuntimeAnimatorController Wick;
    static public Animator anim;

    // Use this for initialization
    void Start()
    {
        health = 100;
        // Retrieves the Player's Rigidbody
        theRB = GetComponent<Rigidbody2D>();
        //Checks if the player selected Pepe as their character
        if (PlayerInfo.Player1char == "Pepe")
        {
            //Sets Damage to 20
            damage = 20;
            //resizes The player to the needed sizes for Pepe
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -1.2f);
            this.transform.localScale = new Vector2(.7f, .8f);
            this.GetComponent<Animator>().runtimeAnimatorController = Pepe;
        }
            //Checks if the player selected Wick as their character
        else if (PlayerInfo.Player1char == "Wick")
        {
            // Sets Damage to 15 for Wick
            damage = 15;
            //Resizes the player to the needed sizes for Wick
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -.3f);
            this.GetComponent<BoxCollider2D>().size = new Vector2(2.5f, 5);
            this.transform.localScale = new Vector2(-1, 1.1f);
            this.GetComponent<Animator>().runtimeAnimatorController = Wick;
            
        }
        //Intstiates the animator of the current character selected
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        //Sets the player's movespeed to the input of the left Joystick Horizontal
        float movespeed = 1;
        movespeed = movespeed * Input.GetAxis("LeftJoystickHorizontal");
        //Disables the player's controls when stunned
        if ( anim.GetFloat("Stunned") <= 0)
        {
            //Disables movement while Punching
            if (!anim.GetBool("Punch"))
            {
                //Gets input for moving
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
            //When the player presses the AButton runs this script
            if (Input.GetButton("P1AButton"))
            {
                anim.SetBool("Punch", true);
                theRB.velocity = new Vector2(0, 0);
            }
            else
            {
                anim.SetBool("Punch", false);
            }

            //When the player presses the  BButton and hasn't had their block broken recently
            if (Input.GetButton("P1BButton") && P2HitDetect.p1BlockWait <= 0)
            {
                anim.SetBool("Block", true);
            }
            else
            {
                //Sets a timer after their block recieves a hit
                P2HitDetect.p1BlockWait -= Time.deltaTime;
                anim.SetBool("Block", false);
            }
        }
        else
        {
            // Sets a timer for how long the player is stunned after being hit
            anim.SetFloat("Stunned", anim.GetFloat("Stunned") - Time.deltaTime);
        }
    }
}
