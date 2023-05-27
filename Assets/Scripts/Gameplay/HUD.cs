using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UIElements;

public class HUD : MonoBehaviour
{
    Timer endTimer;

    float totalGameSeconds = 61;

    // timer support
    [SerializeField]
    TextMeshProUGUI timerText;




    // Start is called before the first frame update
    void Start()
    {
        //creat and start the timer
        endTimer = gameObject.AddComponent<Timer>();
        endTimer.Duration = totalGameSeconds;
        endTimer.Run();
    }

    // Update is called once per frame
    void Update()
    {
        //caso o timer esteja rodando ele diminui os segundos e deixa de forma int
        if (endTimer.Running)
        {
            totalGameSeconds -= Time.deltaTime;
            timerText.text = Mathf.FloorToInt(totalGameSeconds).ToString();
            if (totalGameSeconds < 16)
            {
                timerText.color = Color.red;
            }
        }

        //se o tempo acabar o texto fica vermelho e indica que acabou o tempo
        if (endTimer.Finished)
        {
            SceneManager.LoadScene("GameOver");
        }

    }

}
