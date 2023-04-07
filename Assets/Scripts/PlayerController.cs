using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    private float speed = 20f;
    private float turnSpeed = 10f;
    private float horizontalInput, verticalInput;
    
    void Update()
    {
        // Detectar el Input Horizontal
        horizontalInput = Input.GetAxis("Horizontal");
        // Detectar el Input Vertical
        verticalInput = Input.GetAxis("Vertical");
        
        // Movimiento hacia adelante manual
        transform.Translate(Vector3.forward * speed * 
                            Time.deltaTime * verticalInput);
        
        /*
        // Movimiento lateral manual
        transform.Translate(Vector3.right * 
                            turnSpeed * 
                            Time.deltaTime * 
                            horizontalInput);
        */
        
        // Rotación manual
        transform.Rotate(Vector3.up, 
            turnSpeed * Time.deltaTime * horizontalInput);
    }
}
