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

    // Update is called once per frame

    void Update()
    {
   


    }
private void OnCollisionEnter(Collision collision)
{
    if (collision.gameObject.CompareTag("Player"))
    {
        PotionSpawner potionSpawner = FindAnyObjectByType<PotionSpawner>();
        potionSpawner.RemovePotion(gameObject);
    }
}
}
