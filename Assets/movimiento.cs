using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class movimiento : MonoBehaviour
{
    public float speed;

    private Rigidbody rb;

    

    private void Update()
    {
        float Horizontal = Input.GetAxis("Horizontal");
        float Vertical = Input.GetAxis("Vertical");

        Vector3 vector3 = new Vector3(Horizontal, Vertical, 0);
       transform.Translate(vector3 * speed*Time.deltaTime);

        
    }
}
