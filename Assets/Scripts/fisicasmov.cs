using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fisicasmov : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 vector3 = new Vector3(Horizontal, Vertical, 0);
        rb.velocity = vector3 * speed;

        ;
    }
}
