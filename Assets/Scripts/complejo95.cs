using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class complejo95 : MonoBehaviour
{
    public float speed = 20f;
    
    public float horizontalInput, verticalInput;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        Vector3 vector3=new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(vector3 * speed);

    }
}
