using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move : MonoBehaviour
{
    //Vari�vel que controla a massa/peso
    public float mass = 0.5f;
    //Acessamos o componente Rigidbody atrav�s dessa vari�vel
    private Rigidbody rigidbody;

    public float _velocidade = 20.0f;
    public float _girar = 60.0f;

    // Start is called before the first frame update
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Confined;

        //Assim que o script  � executado, obtemos o componente Rigidbody e atribuimos a nossa vari�vel
        rigidbody = GetComponent<Rigidbody>();
        //Definimos o valor da massa via script
        rigidbody.mass = mass;
    }

    // Update is called once per frame
    void Update()
    {
        float translate = (Input.GetAxis("Vertical") * _velocidade) * Time.deltaTime;
        float rotate = (Input.GetAxis("Mouse X") * _girar) * Time.deltaTime;
        transform.Translate(0, 0, translate);
        transform.Rotate(0, rotate, 0);

    }
}
