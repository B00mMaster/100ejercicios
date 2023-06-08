using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class complejo97 : MonoBehaviour
{
    public float speed = 20f;
    public Transform respawn;

    Vector3 posInicio;
    public float horizontalInput, verticalInput, jumpInput;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");
        jumpInput = Input.GetAxis("Jump");

         Vector3 vector3 = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(vector3 * speed);
        Vector3 vector31 = new Vector3(0, jumpInput, 0);
        rb.AddForce(vector31 * 4, ForceMode.Impulse);

        if (transform.position.y < -6)
        {
            transform.position = posInicio;
            transform.position = respawn.position;
        }
    }

    
}
