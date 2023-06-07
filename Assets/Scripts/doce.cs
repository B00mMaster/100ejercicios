using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doce : MonoBehaviour
{
    public string month = "";

    private void Start()
    {
         if (month is "july" or "august" or "september")

        { Debug.Log($" summer"); }

        else if (month is "april" or "june" or "may" or "march")
        {
            Debug.Log($"spring");
        }
        else if (month is "september" or "octuber")
        {
            Debug.Log($"autumn");
        }

        else if (month is  "december" or "november" or "january")
        {
            Debug.Log($"winter");
        }
    }
}
 