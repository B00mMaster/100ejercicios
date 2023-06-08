using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class canon : MonoBehaviour
{
    public float rot;
    public GameObject bala;
    public Transform balaSpawn;
    
    

    private void Update()
    {
        transform.Rotate(Vector3.up, rot * Time.deltaTime);
        if(Input.GetKeyDown(KeyCode.Space))
            {
            bala = Instantiate(bala, balaSpawn.position, Quaternion.LookRotation(transform.forward));

            Destroy(bala, 5f);


        }
    }
}
