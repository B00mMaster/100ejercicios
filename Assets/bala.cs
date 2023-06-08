using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bala : MonoBehaviour
{
    public float balaSped;

    private void Update()
    {
        transform.Translate(Vector3.forward * balaSped * Time.deltaTime);
    }
}
