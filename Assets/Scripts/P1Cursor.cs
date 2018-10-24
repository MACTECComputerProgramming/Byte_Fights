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
        theRB = GetComponent<Rigidbody2D>();
        Player1 = GetComponent<SpriteRenderer>();
	}

    // Update is called once per frame
    void Update() {
        Movement();
    }
        void Movement()
        {   
            float movespeedy = -1;
     float movespeedx = 1;

        movespeedx = movespeedx * Input.GetAxis("LeftJoystickHorizontal");
        movespeedy = movespeedy * Input.GetAxis("LeftJoystickVertical");
        if (Input.GetAxis("LeftJoystickHorizontal") == 1)
        {
          
            theRB.velocity = new Vector2(movespeedx, theRB.velocity.y);
        }
        else if (Input.GetAxis("LeftJoystickHorizontal") == -1)
        {
            
            theRB.velocity = new Vector2(movespeedx, theRB.velocity.y);
        }
        else if (Input.GetAxis("LeftJoystickVertical") == -1)
        {
       
            theRB.velocity = new Vector2(theRB.velocity.x,movespeedy );
        }
        else if (Input.GetAxis("LeftJoystickVertical") == 1)
        {
           
            theRB.velocity = new Vector2(theRB.velocity.x,movespeedy);
        }
        else
        {

            theRB.velocity = new Vector2(0, 0 );
        }
        }
    private void OnTriggerStay2D(Collider2D collision)
    {
            
       if (Input.GetButton("P1AButton"))
            {
              if (collision.gameObject.name =="PepeButton")
            {
                Debug.Log("Hi");
            PlayerInfo.Player1char = "Pepe";
            }  
            } 
    }
}

