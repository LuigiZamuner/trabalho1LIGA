using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public int points = 0;
    // Start is called before the first frame update
    void Start()
    {
        instance= this;
    }

}
