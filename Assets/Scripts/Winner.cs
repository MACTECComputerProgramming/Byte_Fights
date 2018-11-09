using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Winner : MonoBehaviour {
    //getting health bars

    static public Text Winnertext;
    public Image player2HP;
    public Image player1HP;

    public double swapscenenumber = 5;

	// Use this for initialization

	void Start () {

        // Gets the winner text box
        Winnertext = GetComponent<Text>();
        //Sets the delay for when the game ends
        swapscenenumber = 5;
        
	}
	
	// Update is called once per frame
	void Update () {
        
        // If there is a winner decieded then the loser will leave the screen
        if(player2HP.fillAmount <= 0)
        {
            //The text that will display when Player 1 Wins
            Winnertext.text = "Player 1 Wins ";

            //Finds Player 2 and removes them from the screen
            GameObject.Find("Player 2").transform.localScale = new Vector2(0, 0);

            if (swapscenenumber <= 0)
            {
                //Destroys a gameobject storing information about the previous match
                GameObject.Destroy(GameObject.Find("Assigner"));
                //Loads the Main Page
                SceneManager.LoadScene("Main");
            }
            else
            {
                // Delay for to go back to main menu
                swapscenenumber -= Time.deltaTime;
            }

        }

        // If there is a winner decieded then the loser will leave the screen
        if (player1HP.fillAmount <= 0)

        {
            //The text that will display when Player 2 Wins
            Winnertext.text = "Player 2 Wins ";

            //Finds Player 1 and removes them from the screen
            GameObject.Find("Player 1").transform.localScale = new Vector3(0, 0, 0);

            if (swapscenenumber <= 0)
            {
                //Destroys a gameobject storing information about the previous match
                GameObject.Destroy(GameObject.Find("Assigner"));
                //Loads the Main Page
                SceneManager.LoadScene("Main");
                
            }
            else
            {

                // Delay for to go back to main menu
                swapscenenumber -= Time.deltaTime;
            }
           
        }
    }
}
