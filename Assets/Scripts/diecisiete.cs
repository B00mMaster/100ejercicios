using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;

using System.Runtime.ConstrainedExecution;
using UnityEngine;
using static UnityEditor.Experimental.GraphView.GraphView;
using UnityEngine.Rendering.VirtualTexturing;
public class diecisiete : MonoBehaviour
{
    //Declara una funci�n que reciba dos par�metros float. El primero es el m�nimo valor y, el
    // segundo, el m�ximo valor que pueden valer las componentes del vector aleatorio.La funci�n
    //debe devolver ese vector aleatorio, donde cada componente debe ser de tipo float y debe ser
    //un n�mero entre el m�nimo y el m�ximo obtenidos por par�metro

    public float R(float x,float y)
    {
        float randomNum = Random.Range(x, y);
        return randomNum;
    }









    }
