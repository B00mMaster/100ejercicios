using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class seis : MonoBehaviour
{
    public float num;

    private void Start()
    {
        MayorQueCero(num);
    }
    public bool MayorQueCero( float num)
    {
        if (num > 0)
        {
            Debug.Log($"{num} es mayor que cero");
            return true;
        }
        else if (num == 0)
        {
            Debug.Log($"{num} son las ganas que tengo de hacer esto :P");
            return true;
        }
        Debug.Log($"{num} es menor que cero");
        return false;
    }
}
