using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class complejo92 : MonoBehaviour
{
    public GameObject enemy;

    public TextMeshProUGUI text;

    public int wave= 1;
    int enemis;

 
    void Spawn()
    {
        int enemisNum = wave;

        for(int i=0; i < enemisNum; i++)
        {
            enemy=Instantiate(enemy,RandomPos(), Quaternion.identity);

        }

        enemis = enemisNum;
    }

    private void Update()
    {
        
        if(enemis==0)
        {
            wave++;
            text.text = ""+wave;
            Spawn();
        }
    }
    Vector3 RandomPos()
    {
        float maxX=5f;
        float maxY=5f;
        float minX=-5f;
        float minY=-5f;

        float randomX = Random.Range(maxX, minX);
            float randomY = Random.Range(maxY, minY);

        return new Vector3(randomX, randomY, 0f);
    }

    public void OnMouseDown()
    {
        Destroy(enemy);
        enemis--;
    }
}
