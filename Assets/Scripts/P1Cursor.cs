using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class P1Cursor : MonoBehaviour {
   
    public string buttonName;
    private Transform thisTransform;
    private Rigidbody2D theRB;
    public SpriteRenderer Player1;
	// Use this for initialization
	void Start () {
        //Instantiates the Player's rigidbody and Sprite Renderer within the script
        theRB = GetComponent<Rigidbody2D>();
        Player1 = GetComponent<SpriteRenderer>();
	}

    // Update is called once per frame
    void Update() {
        Movement();
    }
        void Movement()
        {
            //The player's vertical movespeed
        float movespeedy = -5;
            //The player's horizontal movespeed
        float movespeedx = 5;
            //Sets the Players movespeed times the amount of input on the joysticks
        movespeedx = movespeedx * Input.GetAxis("LeftJoystickHorizontal");
        movespeedy = movespeedy * Input.GetAxis("LeftJoystickVertical");
            //Right Movement
        if (Input.GetAxis("LeftJoystickHorizontal") == 1)
        {
          
            theRB.velocity = new Vector2(movespeedx, theRB.velocity.y);
        }
            //Left Movement
        else if (Input.GetAxis("LeftJoystickHorizontal") == -1)
        {
            
            theRB.velocity = new Vector2(movespeedx, theRB.velocity.y);
        }
            //Up movement
        else if (Input.GetAxis("LeftJoystickVertical") == -1)
        {
       
            theRB.velocity = new Vector2(theRB.velocity.x,movespeedy );
        }
            //Down Movement
        else if (Input.GetAxis("LeftJoystickVertical") == 1)
        {
           
            theRB.velocity = new Vector2(theRB.velocity.x,movespeedy);
        }
        else
        {
            //If there is no input it stops the Cursor
            theRB.velocity = new Vector2(0, 0 );
        }
        }
	}

