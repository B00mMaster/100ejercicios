using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class trece : MonoBehaviour
{
    public string a = "a";

    private void Start()
    {
        if (a is "a")
        {
            Debug.Log($"La palabra empieza por {a}");
        }
        else if(a is "A")
        {
            Debug.Log($"La palabra empieza por {a}");
        }
        else
        {
            Debug.Log("La palabra no empieza por la letra a / A”");
        }
    }
}
