using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Complejo98 : MonoBehaviour
{
    public float horizontalInput, verticalInput;
    public float speed = 4f;
    public float rotSpeed = 10f;

   

    // Update is called once per frame
    void Update()
    {
        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime * horizontalInput);

    }

   
}
