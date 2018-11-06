using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerInfo : MonoBehaviour {

    static private string player1char;

    static private string player2char;
    
    
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

    static public bool P1start = false;
    static public bool P2start = false;
    bool fightstart = true;
    public Image p1;
    public Image p2;
   static public bool P1lockedin;
    static public bool P2lockedin;

    // Use this for initialization
    void Start () {
        P1start = false;
        P2start = false;
        P1lockedin = false;
        P2lockedin = false;
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
        if (player1char != null)
        {
            if (Input.GetButton("P1XButton") && P1lockedin == false)
            {
                P1start = true;
                p1.color = Color.green;
                P1lockedin = true;

            }
        }
        if (player2char != null)
        {
            if (Input.GetButton("P2XButton") && P2lockedin == false)
            {
                P2start = true;
                p2.color = Color.green;
                P2lockedin = true;
            }
        }
        if((P1start == true && P2start == true )&& fightstart == true)
        {
            SceneManager.LoadScene("Fight");
            fightstart = false;
            
        }
	}
}
