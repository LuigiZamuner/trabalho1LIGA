using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PotionSpawner : MonoBehaviour
{
    [SerializeField]
    GameObject greenPotionPref;
    [SerializeField]
    GameObject bluePotionPref;
    [SerializeField]
    GameObject redPotionPref;

    [SerializeField]
    private List<GameObject> listaSpawn = new List<GameObject> ();


    // Start is called before the first frame update
    void Start()
    {
            int spawn = Random.Range(0, listaSpawn.Count);
            Instantiate(greenPotionPref, listaSpawn[spawn].transform.position, Quaternion.identity);
            listaSpawn.RemoveAt(spawn);

            spawn = Random.Range(0, listaSpawn.Count);
            Instantiate(bluePotionPref, listaSpawn[spawn].transform.position, Quaternion.identity);
            listaSpawn.RemoveAt(spawn);

            spawn = Random.Range(0, listaSpawn.Count);
            Instantiate(redPotionPref, listaSpawn[spawn].transform.position, Quaternion.identity);
            listaSpawn.RemoveAt(spawn);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
