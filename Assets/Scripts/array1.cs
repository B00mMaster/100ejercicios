using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class array1 : MonoBehaviour
{
    GameObject[] gameObject; 
    
    private void Start()
    {   
        //26
        int[] n = {1,2,3};

        Debug.Log(n[0]);

        
        //28
        string[] s = { "a", "b" };
        Debug.Log(s[1]);

        string[] t = { "a", "b", "c", "d", "e", "f", "g", "h", "j", "k" };
        for (int i = 0; i < t.Length; i += 2)
        { Debug.Log(t[i]); }


        //30
        Vector3[] v = new Vector3[]
        {
            new Vector3(1,2,3),
            new Vector3(2,3,4),
            new Vector3(3,4,5),
            new Vector3(4,5,6),
            new Vector3(5,6,7),
            new Vector3(6,7,8),
            new Vector3(7,8,9),
            new Vector3(8,9,10),
            new Vector3(9,10,11),
            new Vector3(10,11,12),
        };
        for(int i = 1; i < v.Length; i += 2)
        { Debug.Log(v[i]); }

        //31

        string[]a = { "a", "b", "c", "d", "e" };
        int x=Random.Range(0, a.Length);
        Debug.Log(a[x]);

        //32

        Color[]c= new Color[]
        {
            Color.black,
                Color.red
        };
        for(int i=0; i<c.Length; i++)
        {
            Debug.Log(c[i]);
        }

        //33

        int random = Random.Range(0, gameObject.Length);
        Instantiate(gameObject[random], Vector3.zero, Quaternion.identity);

        //34

        string[] z = { "1", "2", "3" };

        if(z.Length>10)
        {
            Debug.Log("El array tiene más de 10 elementos");
        }
        else
        {
            Debug.Log($"El array tiene {z.Length} elementos");
        }
    }
}
