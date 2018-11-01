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
        float movespeedx = 5;
        float movespeedy = -5;
        movespeedx = movespeedx * Input.GetAxis("p2LeftJoystickHorizontal"); 
        movespeedy = movespeedy * Input.GetAxis("p2LeftJoystickVertical");
        if (Input.GetAxis("p2LeftJoystickHorizontal") == 1)
        {

            theRB.velocity = new Vector2(movespeedx, theRB.velocity.y);
        }
        else if (Input.GetAxis("p2LeftJoystickHorizontal") == -1)
        {

            theRB.velocity = new Vector2(movespeedx, theRB.velocity.y);
        }
        else if (Input.GetAxis("p2LeftJoystickVertical") == 1)
        {

            theRB.velocity = new Vector2(theRB.velocity.x, movespeedy);
        }
        else if (Input.GetAxis("p2LeftJoystickVertical") == -1)
        {

            theRB.velocity = new Vector2(theRB.velocity.x, movespeedy);
        }
        else
        {

            theRB.velocity = new Vector2(0, 0);
        }
    }
}
