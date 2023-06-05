using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int points = 0;

    public AudioSource audioSource;
    public AudioSource audioSourceWalk;
    public AudioClip[] audios;
    // Start is called before the first frame update
    void Start()
    {
      
        DontDestroyOnLoad(gameObject);
        instance = this;
    }



}
