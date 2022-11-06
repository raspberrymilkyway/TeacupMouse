using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void LoadScene0(string scene){
        SceneManager.LoadScene(scene);
    }

    public void quit(){
        Debug.Log("quitting");
        Application.Quit();
    }
}