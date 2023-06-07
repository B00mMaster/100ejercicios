using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class dieciocho : MonoBehaviour
{
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left);
        }
        else if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right);
        }
        else if (Input.GetKeyDown(KeyCode.UpArrow))
        {
           transform.Translate(Vector3.up);
        }
        else if ( Input.GetKeyDown(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.down);
        }
    }
}
