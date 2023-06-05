using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    private void Start()
    {
        GameManager.instance.audioSourceWalk.Stop();
        GameManager.instance.audioSource.PlayOneShot(GameManager.instance.audios[4]);
        GameManager.instance.points = 0;
        Cursor.visible = true;
    }
    public void HandleMenuButton()
    {
        GameManager.instance.audioSource.PlayOneShot(GameManager.instance.audios[1]);
        Destroy(GameManager.instance.gameObject);
        SceneManager.LoadScene("Menu");

    }
}
