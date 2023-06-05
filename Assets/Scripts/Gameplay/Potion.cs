using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Potion : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            GameManager.instance.audioSource.PlayOneShot(GameManager.instance.audios[2]);
            //achar o PotionSpawner para usar o medoto de remover pocao que contem nele
            PotionSpawner.potionSpawner.RemovePotion(gameObject);

        }
    }

}
