using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    private void Start()
    {
        GameManager.instance.gameOver.Play();
        Cursor.visible = true;
    }
    public void HandleRetryButton()
    {
        GameManager.instance.menuIn.Play();
        SceneManager.LoadScene("Gameplay");

    }
    public void HandleQuitButton()
    {
        GameManager.instance.menuOut.Play();
        Application.Quit();
    }
}
