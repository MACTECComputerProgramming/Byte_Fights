﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;



public class timer : MonoBehaviour {
    Text text;
    public static float timeLeft = 60f;

	// Use this for initialization
	void Start () {
        text = GetComponent<Text>();
	}
	
	// Update is called once per frame
	void Update () {
        timeLeft -= Time.deltaTime;
        if (timeLeft < 1)

            timeLeft = 1;
        text.text = " " + Mathf.Round(timeLeft);

        if (timeLeft == 1)
            SceneManager.LoadScene("Main");

	
	}
}
