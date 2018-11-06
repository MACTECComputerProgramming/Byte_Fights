using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class Winner : MonoBehaviour {
    static public Text Winnertext;
    public Image player2HP;
    public Image player1HP;
    public double swapscenenumber = 5;
	// Use this for initialization
	void Start () {

        Winnertext = GetComponent<Text>();
        swapscenenumber = 5;
        
	}
	
	// Update is called once per frame
	void Update () {
        

        if(player2HP.fillAmount == 0)
        {
            Winnertext.text = "Player 2 Wins ";
            GameObject.Find("Player 1").transform.localScale = new Vector2(0, 0);
            if (swapscenenumber == 0)
            {
                GameObject.Destroy(GameObject.Find("Assigner"));
                SceneManager.LoadScene("Main");
            }
            else
            {
                swapscenenumber -= 1;
            }
        }

        if (player1HP.fillAmount == 0)
        {
            Winnertext.text = "Player 2 Wins ";
            GameObject.Find("Player 2").transform.localScale = new Vector3(0, 0, 0);
            if (swapscenenumber == 0)
            {
                GameObject.Destroy(GameObject.Find("Assigner"));
                SceneManager.LoadScene("Main");
                
            }
            else
            {
                swapscenenumber -= 1;
            }
           
        }

       
    }
}
