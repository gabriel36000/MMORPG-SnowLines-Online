using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour {

    public Text playerDisplay;
    private void Start()
{
        if (DBManger.LoggedIn)
        {
            playerDisplay.text = "Player:" + DBManger.username; 
        }
}

 public void GoToRegister()
    {
        SceneManager.LoadScene(1);
    }
    public void GoToplay()
    {
        SceneManager.LoadScene(2);
    }

    public void InGame()
    {
        SceneManager.LoadScene(3);
    }
}
