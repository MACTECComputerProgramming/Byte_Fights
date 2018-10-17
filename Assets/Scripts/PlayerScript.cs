using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerScript : MonoBehaviour
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
        movespeed = movespeed * Input.GetAxis("LeftJoystickHorizontal");
        if (Input.GetAxis("LeftJoystickHorizontal") > 0)
        {
            theRB.velocity = new Vector2(movespeed, theRB.velocity.y);
        }
        else if (Input.GetAxis("LeftJoystickHorizontal") < 0)
        {
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
