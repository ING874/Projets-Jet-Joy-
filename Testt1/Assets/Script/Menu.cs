using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{

    public void Play(){
        SceneManager.LoadScene("PLAY");
    }
    
    public void Option(){
        SceneManager.LoadScene("OPTION");
        
    }

    public void Store(){
        
    }
    public void EXIT(){
        Application.Quit();
    }
}