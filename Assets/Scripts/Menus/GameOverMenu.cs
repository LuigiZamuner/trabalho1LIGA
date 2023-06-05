using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverMenu : MonoBehaviour
{
    private void Start()
    {
        GameManager.instance.audioSourceWalk.Stop();
        GameManager.instance.points = 0;
        GameManager.instance.audioSource.PlayOneShot(GameManager.instance.audios[3]);
        Cursor.visible = true;
    }
    public void HandleRetryButton()
    {
        GameManager.instance.audioSource.PlayOneShot(GameManager.instance.audios[0]);
        SceneManager.LoadScene("Gameplay");
    }
    public void HandleQuitButton()
    {
        GameManager.instance.audioSource.PlayOneShot(GameManager.instance.audios[1]);
        Application.Quit();
    }
}
