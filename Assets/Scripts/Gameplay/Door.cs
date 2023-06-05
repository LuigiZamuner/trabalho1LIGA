using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    private BoxCollider boxCollider;
    private CapsuleCollider capsuleCollider;
    private Animator anim;
    Timer timerCollider;
    // Start is called before the first frame update
    void Start()
    {
        //pega os componentes 
        boxCollider= GetComponent<BoxCollider>();
        capsuleCollider= GetComponent<CapsuleCollider>();
        anim = GetComponent<Animator>();

        //pega o timer e define a duracao dele 
        timerCollider = gameObject.AddComponent<Timer>();
        timerCollider.Duration = 4;
    }

    
    // Update is called once per frame
    private void Update()
    {
    

    }

    private void OnCollisionEnter(Collision collision)
    {
        //se o timer tiver acabado ativa novamente os dois colliders
        if (timerCollider.Finished)
        {
            boxCollider.enabled = true;
            capsuleCollider.enabled = true;
        }
        //se o colider da porta enconstar no colider do player a animacao da porta acontece e chama o metodo TimerCollider
        if (boxCollider.bounds.Intersects(collision.collider.bounds))
        {

            anim.SetTrigger("Open");
            TimerCollider();
        }

        if (capsuleCollider.bounds.Intersects(collision.collider.bounds))
        {
            anim.SetTrigger("OpenReverse");
            TimerCollider();
        }
    }

    //metodo que desativa os coliders de interacao durante a animacao
    private void TimerCollider()
    {
        boxCollider.enabled = false;
        capsuleCollider.enabled = false;

        timerCollider.Run();


        
    }
}
