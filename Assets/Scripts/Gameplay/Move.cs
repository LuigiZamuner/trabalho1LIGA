using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Variável que controla a massa/peso
    public float mass = 0.5f;
    //Acessamos o componente Rigidbody através dessa variável
    private Animator anim;
    private Rigidbody rigidbody;
    public float _velocidade = 20.0f;
    public float _girar = 60.0f;
    Timer moveSoundTimer;

    // Start is called before the first frame update
    void Start()
    {

        anim = GetComponent<Animator>();
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;

        //Assim que o script  é executado, obtemos o componente Rigidbody e atribuimos a nossa variável
        rigidbody = GetComponent<Rigidbody>();
        //Definimos o valor da massa via script
        rigidbody.mass = mass;
        GameManager.instance.audioSourceWalk.Play();
    }

    // Update is called once per frame
    void Update()
    {
        float translate = (Input.GetAxis("Vertical") * _velocidade) * Time.deltaTime;
        float rotate = (Input.GetAxis("Mouse X") * _girar) * Time.deltaTime;
        transform.Translate(0, 0, translate);
        transform.Rotate(0, rotate, 0);

        if (translate > 0)
        {           
            anim.SetBool("IsMoving", true);
        }
        else if (translate < 0)
        {           
            anim.SetBool("IsMovingBack", true);
        }
        else
        {        
            anim.SetBool("IsMoving", false);
            anim.SetBool("IsMovingBack", false);  
        }

    }

}
