using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class quince : MonoBehaviour
{
    public bool gO;

    private void Start()
    {
        if(gO==true)
        {
            Debug.Log("Seguimos vivos");
        }
        else
        {
            Debug.Log("GAME OVER");
        }
    }
}
