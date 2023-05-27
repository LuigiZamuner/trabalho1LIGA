using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int points = 0;

    [SerializeField]
    public AudioSource gameOver;
    [SerializeField]
    public AudioSource menuIn;
    [SerializeField]
    public AudioSource menuOut;
    [SerializeField]
    public AudioSource click;
    [SerializeField]
    public AudioSource win;

    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
        instance= this;
    }

}
