using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinMenu : MonoBehaviour
{
    private void Start()
    {
        GameManager.instance.win.Play();
        Cursor.visible = true;
    }
    public void HandleMenuButton()
    {
        GameManager.instance.menuOut.Play();
        SceneManager.LoadScene("Menu");

    }
}
