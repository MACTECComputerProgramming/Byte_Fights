using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
{
    public string buttonName;
    private Transform thisTransform;
    static public double damage = 10;
    static public double health = 100;
    private Rigidbody2D theRB;
    public SpriteRenderer Player1;
    RuntimeAnimatorController thisAnim;
    public RuntimeAnimatorController Pepe;
    public RuntimeAnimatorController Wick;
    static public Animator anim;


    // Use this for initialization
    void Start()
    {
        thisTransform = transform;
        theRB = GetComponent<Rigidbody2D>();
        thisAnim = GetComponent<RuntimeAnimatorController>();
        if (PlayerInfo.Player1char == "Pepe")
        {
            thisAnim = Pepe;
        }
        else if (PlayerInfo.Player1char == "Wick")
        {
            thisAnim = Wick;
        }
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
      

        float movespeed = 1;
        movespeed = movespeed * Input.GetAxis("LeftJoystickHorizontal");
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
        if (Input.GetButton("P1AButton"))
        {
            anim.SetBool("Punch", true);
            theRB.velocity = new Vector2(0,0);

        }
        else
        {
            anim.SetBool("Punch", false);
        }
        if (Input.GetButton("P1BButton"))
        {
            anim.SetBool("Block", true);

        }
        else
        {
            anim.SetBool("Block", true);
        }
        if (Input.GetButton("P1XButton"))
        {


        } if (Input.GetButton("P1YButton"))
        {


        }


        
    }
}
