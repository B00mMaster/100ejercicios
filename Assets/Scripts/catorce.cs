using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class catorce : MonoBehaviour
{
    public string vocal;

    private void Start()
    {
        if (vocal is "a" or "e" or "i" or "u") 
        { 
        Debug.Log($"“La palabra empieza por{vocal}");
        }
        else
        {
            Debug.Log("“La palabra no empieza por voca");
        }

    }

}
