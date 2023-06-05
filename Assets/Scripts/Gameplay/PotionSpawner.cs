using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.TextCore.LowLevel;
using static UnityEditor.Progress;

public class PotionSpawner : MonoBehaviour
{

    [SerializeField]
    private List<GameObject> listaSpawn = new List<GameObject>();

    [SerializeField]
    private GameObject[] potions;
    public static PotionSpawner potionSpawner;
    // Start is called before the first frame update

    void Start()
    {
       
        //salvar alguma posicao random da listas instanciar a pocao e remover a posicao selecionada 
        for(int i =0; i<4; i++)
        {
            int spawn = Random.Range(0, listaSpawn.Count);
            Instantiate(potions[i], listaSpawn[spawn].transform.position, Quaternion.identity);
            listaSpawn.RemoveAt(spawn);

        }
        potionSpawner = this;

    }

   
    public void RemovePotion(GameObject potion)
    {
        //pega a variavel points do gameManager e adiciona 1 cada vez que for chamada
        GameManager.instance.points++;
        Debug.Log(GameManager.instance.points);

        //ifs caso certa quantidade de pontos sejam pegas
        if (GameManager.instance.points == 4)
        {
            SpawnPandoraBox();
        }
        if (GameManager.instance.points == 5)
        {
            SceneManager.LoadScene("Win");
        }

        Destroy(potion);
    }

    public void SpawnPandoraBox()
    {
        int spawn = Random.Range(0, listaSpawn.Count);
        Instantiate(potions[4], listaSpawn[spawn].transform.position, Quaternion.identity);
    }
}
