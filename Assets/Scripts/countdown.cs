using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour
{
    public float totalTime = 60;
    int second;
    public Text timer;

   public void Update()
    {
        while (totalTime > 0)
        {
            totalTime -= Time.deltaTime;
            totalTime = Mathf.RoundToInt(totalTime);
            string formattedSeconds = totalTime.ToString();
            timer.text = formattedSeconds;
            Debug.Log("Run");
           // yield return new WaitForSeconds(1);
        }
    }

    
    
   
    void GameOver()
    {
        Debug.Log("Game Over");
    }
}