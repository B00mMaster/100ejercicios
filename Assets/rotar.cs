using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rotar : MonoBehaviour
{
    public float rot;

    private void Update()
    {
            if(Input.GetKey(KeyCode.Space))
        {
            transform.Rotate(Vector3.up, rot * Time.deltaTime);
        }
    }
}
