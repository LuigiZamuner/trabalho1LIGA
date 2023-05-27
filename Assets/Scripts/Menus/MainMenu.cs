using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void HandlePlayButtonOnClickEvent()
    {
        GameManager.instance.menuIn.Play();
        SceneManager.LoadScene("Gameplay");
        
    }
    public void HandleQuitButtonOnClickEvent()
    {
        GameManager.instance.menuOut.Play();
        Application.Quit();
    }
}
