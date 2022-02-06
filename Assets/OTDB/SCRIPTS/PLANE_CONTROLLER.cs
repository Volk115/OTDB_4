using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PLANE_CONTROLLER : MonoBehaviour
{
    //VELOCIDAD LINEAL
    private float speed = 50;

    //LIMITES
    /*private float rightlim = 300;
    private float leftlim = -360;
    private float backlim = 0;
    private float forwardlim = 0;

    /*
    private float rightlim = -360;
    private float leftlim = 300;
    private float backlim = -370;
    private float forwardlim = 330;
    */

    //VELOCIDAD DE ROTACION
    private float turnspeed = 100;
    private float horizontalInput;
    private float verticalInput;

    void Start()
    {
        transform.position = new Vector3(330, 160, 0);
        
    }

    void Update()
    {
        //VELOCIDAD CONSTANTE HACIA ADELANTE
        transform.Translate(Vector3.forward * speed * Time.deltaTime);

        //ROTACION
        transform.Rotate(Vector3.up, turnspeed * Time.deltaTime * horizontalInput);
        transform.Rotate(Vector3.left, turnspeed * Time.deltaTime * verticalInput);

        horizontalInput = Input.GetAxis("Horizontal");
        verticalInput = Input.GetAxis("Vertical");

        if (Input.GetKey(KeyCode.Q))
        {
            transform.Rotate(Vector3.forward, turnspeed * Time.deltaTime);
        }

        if (Input.GetKey(KeyCode.E))
        {
            transform.Rotate(Vector3.back, turnspeed * Time.deltaTime);
        }

        //LIMITES DE PANTALLA HORIZONTAL
         if (transform.position.z >= rightlim)
         {
            transform.position = new Vector3(transform.position.x, transform.position.y, rightlim);
        }

         if (transform.position.z <= leftlim)
         {
            transform.position = new Vector3(transform.position.x, transform.position.y, leftlim);
        }

        //LIMITES DE PANTALLA VERTICAL
        if (transform.position.x >= forwardlim)
        {
            transform.position = new Vector3(forwardlim, transform.position.y, transform.position.z);
        }

        if (transform.position.x <= backlim)
        {
            transform.position = new Vector3(backlim, transform.position.y, transform.position.z);
        }

    }
}
