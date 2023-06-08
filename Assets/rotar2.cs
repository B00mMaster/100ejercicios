using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotar2 : MonoBehaviour
{
    public float rot;

    private void Update()
    {
        float rotHor = Input.GetAxis("Horizontal");

        if(rotHor > 0)
        {
            transform.Rotate(Vector3.up, rot * Time.deltaTime);
        }
        else if (rotHor < 0)
        {
            transform.Rotate(Vector3.up, -rot * Time.deltaTime);
        }
    }
}
