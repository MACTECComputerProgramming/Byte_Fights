using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class buttonEvent : MonoBehaviour {

    public void PlayGame()
    {
        SceneManager.LoadScene("Character Select");
    }
}
