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
    RuntimeAnimatorController thisAnim;
    public RuntimeAnimatorController Pepe;
    public RuntimeAnimatorController Wick;
    static public Animator anim;


    public float knockBackForce;
    public float knockBackTime;
    private float knockBackCounter;

    // Use this for initialization
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
        thisAnim = GetComponent<RuntimeAnimatorController>();
        if (PlayerInfo.Player1char == "Pepe")
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -12 / 10);
            this.transform.localScale = new Vector2(7 / 10, 8 / 10);
            this.GetComponent<Animator>().runtimeAnimatorController = Pepe;
        }
        else if (PlayerInfo.Player1char == "Wick")
        {
            this.GetComponent<BoxCollider2D>().offset = new Vector2(0, -1 / 3);
            this.transform.localScale = new Vector2(-1, 11 / 10);
            this.GetComponent<Animator>().runtimeAnimatorController = Wick;
        }
        anim = GetComponent<Animator>();
    }
    // Update is called once per frame
    void Update()
    {
        //isHit = Physics2D.OverlapCircle(hitCheckPoint.position, hitCheckRadius, whatIsPlayer);


        float movespeed = 1;
        movespeed = movespeed * Input.GetAxis("p2LeftJoystickHorizontal");
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
        if (Input.GetButton("P2AButton"))
        {
            anim.SetBool("Punch", true);
            theRB.velocity = new Vector2(0, 0);
        }
        else
        {
            anim.SetBool("Punch", false);
        }

        if (Input.GetButton("P2AButton"))
        {
            anim.SetBool("Block", true);
            //inset action
        }
        else
        {
            anim.SetBool("Block", false);
        }

        if (Input.GetButton("P2BButton"))
        {

            //inset action
        }
        if (Input.GetButton("P2XButton"))
        {
            //inset action

        } if (Input.GetButton("P2YButton"))
        {

            //inset action
        }

    }
        public void Knockback(Vector2 direction)
        {
            knockBackCounter = knockBackTime;

            direction = new Vector2(1, 0);

            theRB.velocity = direction * knockBackForce;
        }
}

