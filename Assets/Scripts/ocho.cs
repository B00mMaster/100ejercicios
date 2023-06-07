using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ocho : MonoBehaviour
{
    public int num;
    private void Start()
    {
        IgualACero(num);
    }
    public bool IgualACero(float num)
    {
        if (num == 0)
        {
            Debug.Log($"{num} es igual a 0");
            return true;
        }
        Debug.Log($"{num} no es igual a 0");
        return false;
    }
}
