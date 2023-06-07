using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

using System.Runtime.ConstrainedExecution;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.Rendering.VirtualTexturing;
public class diecisiete : MonoBehaviour
{
    //Declara una función que reciba dos parámetros float. El primero es el mínimo valor y, el
    // segundo, el máximo valor que pueden valer las componentes del vector aleatorio.La función
    //debe devolver ese vector aleatorio, donde cada componente debe ser de tipo float y debe ser
    //un número entre el mínimo y el máximo obtenidos por parámetro

    public float R(float x,float y)
    {
        float randomNum = Random.Range(x, y);
        return randomNum;
    }









    }
