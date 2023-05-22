using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A timer
/// </summary>
public class Timer : MonoBehaviour
{
    #region Fields

    // timer duracao
    float totalSeconds = 0;

    // timer execucao
    float elapsedSeconds = 0;
    bool running = false;

    // support pra quando terminar
    bool started = false;

    #endregion

    #region Properties

    /// <summary>
    /// aplica a duracao do timer
    /// a duracao apenas pode ser aplicada se o timer nao estiver rodando
    /// </summary>
    /// <value>duration</value>
    public float Duration
    {
        set
        {
            if (!running)
            {
                totalSeconds = value;
            }
        }
    }

    /// <summary>
    /// pega se o timer finalizou ou nao
    /// essa propriedade retorna falso caso o timer n tenha comecado
    /// </summary>
    /// <value>true if finished; otherwise, false.</value>
    public bool Finished
    {
        get { return started && !running; }
    }

    /// <summary>
    /// pega se o timer esta running
    /// </summary>
    /// <value>true if running; otherwise, false.</value>
    public bool Running
    {
        get { return running; }
    }

    #endregion

    #region Methods

    /// <summary>
    /// Update is called once per frame
    /// </summary>
    void Update()
    {
        // update timer e checa se terminou
        if (running)
        {
            elapsedSeconds += Time.deltaTime;
            if (elapsedSeconds >= totalSeconds)
            {
                running = false;
            }
        }
    }

    /// <summary>
    /// Runs the timer
    /// set the duration to something higher than 0
    /// </summary>
    public void Run()
    {
        // se a duracao for valida
        if (totalSeconds > 0)
        {
            started = true;
            running = true;
            elapsedSeconds = 0;
        }
    }

    #endregion
}
