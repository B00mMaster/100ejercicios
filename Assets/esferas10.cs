using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class esferas10 : MonoBehaviour
{
    public Button button;
    public Vector3[] positions;
    public GameObject esfera;

    private void Start()
    {
        button.onClick.AddListener(Esfera);
    }

    void Esfera()
    {
        int random=Random.Range(0,positions.Length);
        Vector3 vector3 = positions[random];

        Instantiate(esfera, vector3, Quaternion.identity);
    }
}
