using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadScene : MonoBehaviour {

    public void load()
    {
        SceneManager.LoadScene("Character_Select");
    }
<<<<<<< HEAD
    void Update()
    {

    }

    private void OnTriggerEnter(Collider coll) 
    {
            if(Input.GetButtonDown("P1AButton"))
            {
                SceneManager.LoadScene("Character_Select");
            }
            else if (Input.GetButtonDown("P2AButton"))
            {
                SceneManager.LoadScene("Character_Select");
            }
        
    }
   
=======
>>>>>>> 43f68a50566285439b5590885221492173c254d7
	
		
	
}
