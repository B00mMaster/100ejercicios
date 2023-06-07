using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class siete : MonoBehaviour
{
    public float num;

    private void Start()
    {
        MenorQueCero(num);
    }
    public bool MenorQueCero(float num)
    {
        if (num <= 0)
        {
            Debug.Log($"{num} es menor o igual que cero");
            return true;
        }
        Debug.Log($"{num} es mayor que cero");
        return false;
    }
}
