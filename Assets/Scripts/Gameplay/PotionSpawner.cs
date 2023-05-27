using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.LowLevel;
using static UnityEditor.Progress;

public class PotionSpawner : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> listaSpawn = new List<GameObject>();

    [SerializeField]
    private GameObject[] potions;

    public int points = 0;

    // Start is called before the first frame update

    void Start()
    {
        //salvar alguma posicao random da listaz instanciar a pocao e remover a posicao selecionada 
        for(int i =0; i<4; i++)
        {
            int spawn = Random.Range(0, listaSpawn.Count);
            Instantiate(potions[i], listaSpawn[spawn].transform.position, Quaternion.identity);
            listaSpawn.RemoveAt(spawn);

        }
 

    }

   
    public void RemovePotion(GameObject potion)
    {
        points++;
        Debug.Log(points);
        if (points == 4)
        {
            SpawnPandoraBox();
        }
        Destroy(potion);
    }

    public void SpawnPandoraBox()
    {
        int spawn = Random.Range(0, listaSpawn.Count);
        Instantiate(potions[4], listaSpawn[spawn].transform.position, Quaternion.identity);
        listaSpawn.RemoveAt(spawn);
    }
}
