using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class nueve : MonoBehaviour
{
    public int year;

    private void Start()
    {
        IsLeapYear(year);
    }




    public bool IsLeapYear(int theYear)
    {
        if (0 == theYear % 4)
        {
            if (0 == theYear % 100)
            {
                if (0 == theYear % 400)
                {
                    Debug.Log($"{theYear} es un a�o bisiesto");
                    return true;
                }
                else
                {
                    Debug.Log($"{theYear} no es un a�o bisiesto");
                    return false;
                }
            }
            else
            {
                Debug.Log($"{theYear} no es un a�o bisiesto");
                return false;
            }


        }
        else
        {
            Debug.Log($"{theYear} no es un a�o bisiesto");
        }

        return false;
    }
}
