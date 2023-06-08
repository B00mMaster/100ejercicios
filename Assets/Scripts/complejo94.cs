using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class complejo94 : MonoBehaviour
{
    public float speed = 20f;
    public float rotSpeed = 10f;
    public float horizontalInput, verticalInput;
    public GameObject winPanel;
    public TextMeshProUGUI countText;
    private int count = 0;
    int total;

    private void Start()
    {
        total = GameObject.FindGameObjectsWithTag("Coin").Length;
        CountText();

    }
    void Update()
    {

        verticalInput = Input.GetAxis("Vertical");
        horizontalInput = Input.GetAxis("Horizontal");

        transform.Translate(Vector3.forward * speed * Time.deltaTime * verticalInput);

        transform.Rotate(Vector3.up, rotSpeed * Time.deltaTime * horizontalInput);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Coin"))
        {
            count++;
           
            Destroy(other.gameObject);
            
        }

    }

    void CountText()
    {
        countText.text = ""+count;
    }

    void Win()
    {
        winPanel.SetActive(true);
    }
}
