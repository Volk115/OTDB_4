using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ROTATE_OBJECT : MonoBehaviour
{
    //VELOCIDAD DE ROTACION
    public float rotateSpeed = 800;

    //SE LLAMA AL SCRIPT PLAYER CONTROLLER
    public PLANE_CONTROLLER playerControllerScript;

   void Start()
   {
        playerControllerScript = FindObjectOfType<PLANE_CONTROLLER>();
   }

    /*void Update()
    {
        if (!playerControllerScript.gameOver)
        {
            transform.Rotate(Vector3.up * Time.deltaTime * rotateSpeed);
        }
    }
    */
}
