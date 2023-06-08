using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento87 : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    Vector3 posInicio;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
        posInicio = transform.position;
    }

    private void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 vector3 = new Vector3(Horizontal, Vertical, 0);
        transform.Translate(vector3 * speed * Time.deltaTime);

        if(transform.position.y<-6)
        {
            transform.position = posInicio;
            rb.velocity = Vector3.zero;
            rb.angularVelocity = Vector3.zero;
        }
    }
}
