using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Complejo96 : MonoBehaviour
{
    public float speed = 20f;
    public int live = 10;
    public int point;
    public TextMeshProUGUI textLive;
    public TextMeshProUGUI textPOINT;
    public float horizontalInput, verticalInput;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }
    void Update()
    {

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        Vector3 vector3 = new Vector3(horizontalInput, 0, verticalInput);
        rb.AddForce(vector3 * speed);

    }

    private void OnTriggerEnter(Collider other)
    {
        
        if (other.gameObject.CompareTag("Coin"))
        {

           textPOINT.text=$"POINTS:{point++}";
            Destroy(other.gameObject);

        }
        if (other.gameObject.CompareTag("PowerUp"))
        {
            textLive.text = $"LIVES:{live++}";
            Destroy(other.gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            textLive.text = $"LIVES:{live--}";
        }
    }
}
