using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class timer : MonoBehaviour {

    Text timetext;

    float waittime;

    public static float timeLeft = 60f;

	// Use this for initialization
	void Start () {

        timeLeft = 60f;
        waittime = 5;
        timetext = GetComponent<Text>();
	}
	
	// Update is called once per frame
    // uses delta time for countdown
	void Update () {
        timeLeft -= Time.deltaTime;
        //text turns red when 10 sec are left
        if(timeLeft <= 10)
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
            if(PlayerScript.health > p2PlayerScript.health)
            {
                Winner.Winnertext.text = "Player 1 Wins";
                if(waittime <= 0)
                {
                    SceneManager.LoadScene("Main");
                }
                else
                {
                    waittime -= Time.deltaTime;
                }
            }

                // player 2 wins
        else if (p2PlayerScript.health > PlayerScript.health)
        {
            Winner.Winnertext.text = "Player 2 Wins";
            if (waittime <= 0)
            {
                SceneManager.LoadScene("Main");
            }
            else
            {
                waittime -= Time.deltaTime;
            }
        }

                // Tie 
        else if (PlayerScript.health == p2PlayerScript.health) {

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
