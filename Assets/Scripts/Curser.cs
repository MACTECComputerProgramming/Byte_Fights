using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Curser : MonoBehaviour {
    public string buttonName;
    private Transform thisTransform;
    private Rigidbody2D theRB;
    public SpriteRenderer Player1;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
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

      
        movespeed = movespeed * Input.GetAxis("LeftJoystickVertical");
        if (Input.GetAxis("LeftJoystickVertical") == 1)
        {
            Player1.flipX = false;
            theRB.velocity = new Vector2(movespeed, theRB.velocity.y);
        }
        else if (Input.GetAxis("LeftJoystickVertical") == -1)
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
	}
}
