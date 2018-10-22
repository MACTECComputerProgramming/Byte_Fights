using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour
{
    public float totalTime = 60;
    int seconds;
    public Text timer;
    void Update()
    {

        while (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
            seconds = Mathf.RoundToInt(totalTime);
            string formattedSeconds = seconds.ToString();
            timer.text = formattedSeconds;
        }
        while (totalTime <= 0)
        {
            GameOver();
        }
    
    if (PlayerScript.health <= 0 || p2PlayerScript.health <= 0)
    {
        GameOver();
    }
    }
   
    void GameOver()
    {
        Debug.Log("Game Over");
    }
}