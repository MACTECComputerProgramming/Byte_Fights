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


    // Use this for initialization
    void Start()
    {
        thisTransform = transform;
        theRB = GetComponent<Rigidbody2D>();
    }

    void OnCollisionEnter(Collision col)
    {
        if (col.gameObject.name == "Player 1")
        {
           
            health -= damage;

        }
    }

    // Update is called once per frame
    void Update()
    {
       
        //isHit = Physics2D.OverlapCircle(hitCheckPoint.position, hitCheckRadius, whatIsPlayer);
      

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
        if (Input.GetButton("AButton"))
        {

            //inset action
        }
        if (Input.GetButton("BButton"))
        {

            //inset action
        }
        if (Input.GetButton("XButton"))
        {
            //inset action

        } if (Input.GetButton("YButton"))
        {

            //inset action
        }


        /*if(hit)
         * {
         *  damage = Random Numb<100;
         *  health = health-damage;
         *  }*/

        
    }
}
