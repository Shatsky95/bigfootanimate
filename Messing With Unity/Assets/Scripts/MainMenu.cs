using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour{
//Indexed Level to Load
    public int LevelToLoad;
    //this function loads the level stored in the levelToLoad variable

    public void LoadLevel(){
        SceneManager.LoadScene(LevelToLoad);
    
    }
//this function quits the game after the button is pressed
    public void LevelExit(){
        Application.Quit();
    }



  
}
