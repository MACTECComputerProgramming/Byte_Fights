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
	void Update () {
        timeLeft -= Time.deltaTime;
        if(timeLeft <= 10)
        {
            timetext.color = Color.red;
        }
        if (timeLeft < 1)

            timeLeft = 0;
        timetext.text = " " + Mathf.Round(timeLeft);

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
