using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class veintitres : MonoBehaviour
{
   Vector3 mas= new Vector3(1,1,1);
    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            transform.localScale += mas;
        }
    }
}
