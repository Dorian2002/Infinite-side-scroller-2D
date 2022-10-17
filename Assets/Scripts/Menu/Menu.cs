using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public void StartGame()
    {
        SceneManager.LoadSceneAsync("Game");
    }
    
    public void GoToMenu()
    {
        SceneManager.LoadSceneAsync("Menu");
    }
    
    public void Quit()
    {
        Application.Quit();
    }
}
