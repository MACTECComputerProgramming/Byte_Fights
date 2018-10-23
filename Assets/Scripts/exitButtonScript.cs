using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class exitButtonScript : MonoBehaviour {

    public void QuitGame()
    {
        Application.Quit();
        Debug.Log("Game is exiting");
        //just to check if it's working.
    }


}
    
   

