using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class countdown : MonoBehaviour
{
    public Text time;
    public float targetTime = 60;
    public float timee = 100;
    public bool timeup = true;
    public Renderer rend;
    public bool pause = true;


    void Awake()
    {
        //Stops timer from being removed
        DontDestroyOnLoad(GameObject.Find("Canvas"));
    }


    // Update is called once per frame
    void Update()
    {

        if (pause == true)
        {
            do
            {
                targetTime -= Time.deltaTime;
                string timerString = targetTime.ToString();
                time.text = timerString;
            } while (timeup);

        }

        if (targetTime <= 0)
        {
            //load game over
        }
    }
}