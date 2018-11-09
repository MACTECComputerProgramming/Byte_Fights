using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class timer : MonoBehaviour
{

    Text timetext;

    float waittime;

    public static float timeLeft = 60f;

    // Use this for initialization
    void Start()
    {

        timeLeft = 60f;
        waittime = 5;
        timetext = GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        // uses delta time for countdown
        timeLeft -= Time.deltaTime;
        //turns text red when 10 sec are left
        if (timeLeft <= 10)
        {
            timetext.color = Color.red;
        }
        if (timeLeft < 1)

            timeLeft = 0;

        timetext.text = " " + Mathf.Round(timeLeft);
        // subtracts from time then when = 0 it changes scene
        //Declares winners
        // player one wins
        if (timeLeft < 1)
        {
            //Checks if Player 1 has more health than player 2
            if (PlayerScript.health > p2PlayerScript.health)
            {
                // If player 1 has more hp displays this text
                Winner.Winnertext.text = "Player 1 Wins";
                if (waittime <= 0)
                {
                    //Changes Scene to main
                    SceneManager.LoadScene("Main");
                }
                else
                {
                    waittime -= Time.deltaTime;
                }
            }

                //Checks if Player 2 has more health than player 1
            else if (p2PlayerScript.health > PlayerScript.health)
            {
                //If player 2 has more hp displays this text
                Winner.Winnertext.text = "Player 2 Wins";
                if (waittime <= 0)
                {
                    //Changes the scene to main
                    SceneManager.LoadScene("Main");
                }
                else
                {
                    waittime -= Time.deltaTime;
                }
            }
            // if both players have the same amount of hp 
            else if (PlayerScript.health == p2PlayerScript.health)
            {
                //Displays this text when both players have the same amount of health
                Winner.Winnertext.text = "Nobody Wins";
                if (waittime <= 0)
                {
                    SceneManager.LoadScene("Main");
                }
                else
                {
                    waittime -= Time.deltaTime;
                }


            }

        }
    }
}
