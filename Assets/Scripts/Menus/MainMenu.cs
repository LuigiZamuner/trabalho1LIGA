using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void HandlePlayButtonOnClickEvent()
    {
        GameManager.instance.audioSource.PlayOneShot(GameManager.instance.audios[0]);
        SceneManager.LoadScene("Gameplay");
        
    }
    public void HandleQuitButtonOnClickEvent()
    {
        GameManager.instance.audioSource.PlayOneShot(GameManager.instance.audios[1]);
        Application.Quit();
    }
}
