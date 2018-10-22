using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P2Cursor : MonoBehaviour {
    public string buttonName;
    private Transform thisTransform;
    private Rigidbody2D theRB;
    public SpriteRenderer Player1;
    // Use this for initialization
    void Start()
    {
        theRB = GetComponent<Rigidbody2D>();
        Player1 = GetComponent<SpriteRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        Movement();
    }
    void Movement()
    {
        float movespeed = 1;
        movespeed = movespeed * Input.GetAxis("p2LeftJoystickHorizontal");
        if (Input.GetAxis("p2LeftJoystickHorizontal") == 1)
        {

            theRB.velocity = new Vector2(movespeed, theRB.velocity.y);
        }
        else if (Input.GetAxis("p2LeftJoystickHorizontal") == -1)
        {

            theRB.velocity = new Vector2(movespeed, theRB.velocity.y);
        }
        else
        {

            theRB.velocity = new Vector2(0, theRB.velocity.y);
        }


        movespeed = movespeed * Input.GetAxis("p2LeftJoystickVertical");
        if (Input.GetAxis("p2LeftJoystickVertical") == 1)
        {

            theRB.velocity = new Vector2(theRB.velocity.y, movespeed);
        }
        else if (Input.GetAxis("p2LeftJoystickVertical") == -1)
        {

            theRB.velocity = new Vector2(theRB.velocity.y, movespeed);
        }
        else
        {

            theRB.velocity = new Vector2(0, theRB.velocity.y);
        }
    }
}
