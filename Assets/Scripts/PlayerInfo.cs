using System.Collections;
using System.Collections.Generic;
using UnityEngine;
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


    // Use this for initialization
    void Start () {
        DontDestroyOnLoad(this);
	}
	
	// Update is called once per frame
	void Update () {
        /*if (SceneManager.sceneCount.Equals(1))
        {
            if (player1char == "Pepe")
            {
                GameObject.Find("Player1").SetActive(true);
            }
            if (player2char == "Pepe")
            {
                GameObject.Find("Player2").SetActive(true);
            }
        }*/
        if (Input.GetButton("P1XButton"))
        {
            P1start = true;
        }
        if (Input.GetButton("P2XButton"))
        {
            P2start = true;
        }
        if((P1start == true || P2start == true )&& fightstart == true)
        {
            SceneManager.LoadScene("Fight");
            fightstart = false;
            
        }
	}
}
