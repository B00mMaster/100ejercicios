using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cinco : MonoBehaviour
{
    public int num;

    private void Start()
    {
        parImpar(num);
    }
    public bool parImpar(int num)
    {
        if(num%2==0)
        {
            Debug.Log($"{num} es par");
            return true;
        }
        Debug.Log($"{num} es impar");
        return false;
    }


}
