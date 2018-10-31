using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor.SceneManagement;
using UnityEngine.UI;

public class Winner : MonoBehaviour {
    public Text text;
    public Image player2HP;
    public Image player1HP;
    
	// Use this for initialization
	void Start () {

        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {


        if (player2HP.fillAmount == 0)
       {
           text.text = "Player 1 Wins ";
       }

        if (player1HP.fillAmount == 0)
        {
            text.text = "Player 2 Wins ";
        }

    }
}
