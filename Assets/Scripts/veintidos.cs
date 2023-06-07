using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veintidos : MonoBehaviour
{
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.A))
        {
            transform.Translate(Vector3.left);
        }
        else if (Input.GetKeyDown(KeyCode.D))
        {
            transform.Translate(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.W))
        {
            transform.Translate(Vector3.up);
        }
        else if (Input.GetKeyDown(KeyCode.S))
        {
            transform.Translate(Vector3.down);
        }
    }
}
