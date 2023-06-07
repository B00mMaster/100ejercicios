using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Corutinas : MonoBehaviour
{
    public GameObject esfera;
    public GameObject cubo;
    public GameObject cilindro;
    public GameObject cilindro2;
    public Vector3[] pos ;
    public int index = 0;

    public Vector3[] pos2;
    public int index2;

    public int grados = 20;


    public float max = 2.5f;
    public float min = 0.5f;

    public TextMeshProUGUI text;
    public string ver;

    public bool gameOver = false;

    bool corutina = true;

    private void Start()
    {
        StartCoroutine(RandomColor());
        StartCoroutine(CubeScale());
        StartCoroutine(MoveCilind());
        StartCoroutine(MoveCilind2());
        StartCoroutine(CubeRot());
        StartCoroutine(Text());

    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            corutina = false;
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            corutina = false;
        }
    }
    private IEnumerator RandomColor()
    {
        while(!gameOver)
        {               
            Color random = Random.ColorHSV();

                yield return new WaitForSeconds(1f);

            
        }
    }
    IEnumerator CubeScale()
    {
        while (!gameOver)
        { Vector3 randomScale = new Vector3(Random.Range(0,1), Random.Range(0,1), Random.Range(0,1));

            cubo.transform.localScale=randomScale;
            yield return new WaitForSeconds(2f);
        }
    }

    IEnumerator MoveCilind()
    {
        while(index<pos.Length)
        {
            Vector3 vector3 = pos[index];

            while (transform.position !=vector3)
            {

                transform.position = Vector3.MoveTowards(transform.position,vector3, 1 * Time.deltaTime);
                yield return null;
            }
        }
        index++;
        yield return new WaitForSeconds(1);
    }

    IEnumerator MoveCilind2()
    {
        while (corutina)
        {
            Vector3 vector3 = pos2[index];

            while (transform.position != vector3)
            {

                transform.position = Vector3.MoveTowards(transform.position, vector3, Time.deltaTime);
                yield return null;
            }
        }
        index++;
        if(index2>=pos2.Length)
        {
            index2 = 0;
        }
        float wait = Random.Range(max, min);
        yield return new WaitForSeconds(wait);
    }

    IEnumerator CubeRot()
    {
        while(corutina)
        {
            transform.Rotate(Vector3.up, 20);
                yield return new WaitForSeconds(0.5f);
        }
    }

    IEnumerator Text()
    {
        for (int i=0;i<ver.Length;i++)
        {
            text.text+=ver[i];
            yield return new WaitForSeconds(0.2f);
        }
    }
    void GameOver()
    {
        gameOver=true;
    }
}
