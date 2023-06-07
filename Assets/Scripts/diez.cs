using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class diez : MonoBehaviour
{
    public int dia;

    private void Start()
    {
        Semana(dia);
    }

    bool Semana(int dia)
    {
        if(dia>=6)
        {
            Debug.Log($"El número {dia} pertenece al fin de semana");
            return true;
        }
        Debug.Log($"El número {dia} no pertenece al fin de semana");
        return false;
    }
}
