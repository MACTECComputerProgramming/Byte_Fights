using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class p2PlayerScript : MonoBehaviour
{
    private string horizontalAxis;
    private string verticalAxis;
    private string aButton;
    private string bButton;
    private string triggerAxis;
    private int controllerNumber;
    public float jumpForce;
    public string buttonName;
    private Vector2 startPos;
    public string inputName;
    private Transform thisTransform;

    public Transform hitCheckPoint;
    public float hitCheckRadius;
    public bool isHit;
    public LayerMask whatIsPlayer;
    double damage = 0;
    private Rigidbody2D theRB;
    public SpriteRenderer Player2;
    public Slider Playerslider;

    
    // Use this for initialization
    void Start()
    {
        thisTransform = transform;
        startPos = this.transform.position;
        theRB = GetComponent<Rigidbody2D>();
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
        if (Input.GetButton("Abutton"))
        {
            if (isHit)
            {
                damage += .1;
                
            }

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



    
    /*public void HealthBar(double damage)
    {
        Playerslider.value = (float)damage;


    }
 /*   internal void SetControllerNumber (int number)
    {
        controllerNumber = number;
        horizontalAxis = "J" + controllerNumber + "LeftJoystickHorizontal";
        verticalAxis = "J" + controllerNumber + "LeftJoystickVertical";
        aButton = "J" + controllerNumber + "A";
        bButton = "J" + controllerNumber + "B";
        triggerAxis = "J" + controllerNumber + "Trigger";
    }*/
}
