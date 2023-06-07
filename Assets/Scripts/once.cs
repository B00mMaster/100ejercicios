using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;
using static UnityEditor.PlayerSettings;
using UnityEngine.Rendering.VirtualTexturing;

public class once : MonoBehaviour
{
    public string month = "";

    private void Start()
    {
        if (month is "february")

        { Debug.Log($"{month} has 28 days"); }

        else if (month is "january" or "march" or "may" or "july" or "august" or "octuber" or "december")

        { Debug.Log($"{month} has 31 days"); }

        else if (month is "april" or "june" or "september" or "november")
        {
            Debug.Log($"{month} has 30 days.");
        }

    }
}
