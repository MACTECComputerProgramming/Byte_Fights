using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour {

    static private string player1char;

    static private string player2char;
    
    //The getters and Setters for the players characters
    static public string Player1char
    {
        get
        {
            return player1char;
        }

        set
        {
            player1char = value;
        }
    }

    static public string Player2char
    {
        get
        {
            return player2char;
        }

        set
        {
            player2char = value;
        }
    }

    //Instantiates the bools for when the players have selected characters
    static public bool P1start = false;
    static public bool P2start = false;
    //Instantiates the boolean for when the fight will begin
    bool fightstart = true;
    //Instantiates player images
    public Image p1;
    public Image p2;
    //Instatiates the players' locked in bools
   static public bool P1lockedin;
    static public bool P2lockedin;

    // Use this for initialization
    void Start () {
        //brings all static variables back to their original values
        player1char = null;
        player2char = null;
        P1start = false;
        P2start = false;
        P1lockedin = false;
        P2lockedin = false;
        // Stops the object this script is attached too from being destroyed
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
        //Checks if player 1 has selected a character
        if (player1char != null)
        {
            //Locks in player 1's current chosen character
            if (Input.GetButton("P1XButton") && P1lockedin == false)
            {
                P1start = true;
                p1.color = Color.green;
                P1lockedin = true;

            }
        }
        //Checks if the player has selected a character
        if (player2char != null)
        {
            //Locks in Player 2's current chosen character
            if (Input.GetButton("P2XButton") && P2lockedin == false)
            {
                P2start = true;
                p2.color = Color.green;
                P2lockedin = true;
            }
        }
        // Checks if both players have chosen and locked in their character and begins the Fight
        if((P1start == true && P2start == true )&& fightstart == true)
        {
            SceneManager.LoadScene("Fight");
            fightstart = false;
            
        }
	}
}
