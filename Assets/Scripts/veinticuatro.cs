using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veinticuatro : MonoBehaviour
{
    Vector3 menos = new Vector3(1, 1, 1);
    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(transform.localScale.x>menos.x && transform.localScale.y > menos.y &&transform.localScale.z>menos.z)
            
            transform.localScale -= menos;
        }
    }
}
