using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class bucles : MonoBehaviour

{ /*
    private void Start()
    {
        for (int i = 10; i > 0; i--)
        {
            Debug.Log(i);
        }


        //38
        for (int i = 100; i > 0; i--)
        {
            Debug.Log(i);
        }

        //39

        for (int i = 1; i <= 100; i++)
        {
            if (i % 2 == 0)
            {
                Debug.Log(i);
            }
        }

        //40

        for (int i = 100; i > 0; i--)
        {
            if (i % 2 != 0)
            {
                Debug.Log(i);
            }
        }
        //41

        for (int i = 100; i <= 200; i++)
        {
            if (i % 5 == 0)
            {
                Debug.Log(i);
            }
        }
        //42
       string[] s = { "do", "re", "al", "es" };
       for (int i = 0; i < s.Length; i++)
       {
           if (Vocal(s[i]))
           { Debug.Log($"{s[i]}"); }
       }

       bool Vocal(string s)
       {
           string letra = s.Substring(0, 1);
           return letra == ("a") || letra == "e" || letra == "i" || letra == "o" || letra == "u";
       }
       //43

       string[] a = { "a", "e", "i" };
       for (int i = 0; i < a.Length; i++)
       {

           Debug.Log(i + a[i]);
       }

//44

        public string[] strin;

    void MostrarValor()
    {
        for (int i = 0; i < strin.Length; i++)
        {
            string value = strin[i];
            Debug.Log(value + i);
        }

    }

    //45

    public int[] par;

    void Pares()
    {

        for (int i = 0; i < par.Length; i++)
        {
            int num = par[i];
            if (num % 2 == 0)
            {
                Debug.Log(num);
            }
        }
    }

    //46
    public int[] j;


    void ParesA()
    {
        int pares = 0;
        for (int i = 0; i < j.Length; i++)
        {
            int num = j[i];
            if (num % 2 == 0)
            {
                Debug.Log(pares++);
            }
        }
    }

    // 48

    public int[] y;


    void Impares()
    {
        int impares = 0;
        for (int i = 0; i < y.Length; i++)
        {
            int num = y[i];
            if (num % 2 != 0)
            {
                Debug.Log(impares++);
            }
        }
    }

    //47

    public int[] a;


    void ImparesA()
    {

        for (int i = 0; i < a.Length; i++)
        {
            int num = a[i];
            if (num % 2 != 0)
            {
                Debug.Log(num);
            }
        }
    }

    //49

    public int[] b;


    void ImparesPares()
    {
        int par = 0;
        int imp = 0;

        for (int i = 0; i < a.Length; i++)
        {
            int num = a[i];
            if (num % 2 != 0)
            {
                Debug.Log(par++);
            }
            else { Debug.Log(imp++); }
        }
    }

    //50

    public int[] c;

    void Positivos()
    {
        int pos = 0;
        for (int i = 0; i < c.Length; i++)
        {
            int num = c[i];
            if (num > 0)
            {
                Debug.Log(pos++);
            }
        }
    }

    //51

    public float[] d;

    void Tres()
    {
        int pos = 0;
        int neg = 0;
        int cero = 0;

        for (int i = 0; i < d.Length; i++)
        {
            float num = d[i];
            if (num > 0)
            {
                Debug.Log(pos++);
            }
            else if (num < 0)
            {
                Debug.Log(neg++);
            }
            else { Debug.Log(cero); }
        }

    }

    //52

    void RandomSiete()
    {
        int num = 0;
        while (num != 7)
        {
            num = Random.Range(1, 11);
            Debug.Log(num);
        }
    }

    //53

    void RandomYear()
    {
        int year = 0;

        while (!LeapYear(year))
        {
            year = Random.Range(1, 2024);
            Debug.Log(year);
        }
    }

    bool LeapYear(int year)
    {
        if (year % 4 == 0)
        {
            if (year % 100 == 0)
            {
                if (year % 400 == 0)
                {
                    return true;
                }
                return false;
            }
            return true;
        }
        return false;
    }

    //54

    void RandomMil()
    {
        int num = 0;

        while (num % 5 != 0)
        {
            num = Random.Range(1, 1001);
            Debug.Log(num);
        }
    }

    //55

    public int[] e;


    int Producto()
    {
        int prod = 1;

        for (int i = 0; i < e.Length; i++)
        {
            prod *= e[i];
        }
        return prod;
        Debug.Log(prod);
    }

    //56

    public float[] ai;

    float Suma()
    {
        float sum = 0f;
        for (int i = 0; i < ai.Length; i++)
        {
            if (ImparesB(ai[i]))
            { sum += ai[i]; }
        }
        return sum;
        Debug.Log(sum);
    }

    bool ImparesB(float num)
    {
        return num % 2 != 0;

    }

    //57

    public float[] f;

    float SumaImp()
    {
        float sum = 0f;
        for (int i = 0; i < f.Length; i++)
        {
            if (ImparesC(f[i]))
            { sum += f[i]; }
        }
        return sum;
        Debug.Log(sum);
    }

    bool ImparesC(float num)
    {
        return num % 2 != 0;

    }

    bool ParesC(float num)
    {
        return num % 2 == 0;

    }

    float Sumapar()
    {
        float sum = 0f;
        for (int i = 0; i < f.Length; i++)
        {
            if (ParesC(f[i]))
            { sum += f[i]; }
        }
        return sum;
        Debug.Log(sum);
    }

    //58

    public GameObject esfera;
    public int max = 20;
    public float minPos = -20f;
    public float maxPos = 20f;

    void SpawnSfer()
    {
        //for (int i = 0; i < max; i++)
        {
            //Vector3 pos =
            //float x = Random.Range(minPos, maxPos);
           // float y = Random.Range(minPos, maxPos);
           // float z = Random.Range(minPos, maxPos);

            //return new Vector3(x, y, z);

            //Instantiate(esfera, pos, Quaternion.identity);
        }
    }

    //60

    public GameObject cubo;
    public int cubos = 20;
    public float radio;


    void SpawnCub()
    {
        for (int i = 0; i < cubos; i++)
        {
            Vector3 randomPosition = GetRandomPos();
            Instantiate(cubo, randomPosition, Quaternion.identity);
        }
    }

    Vector3 GetRandomPos()
    {                               //Instancia punto random                
        Vector3 randomPos = Random.insideUnitSphere * radio;
        randomPos.y = 0f;
        randomPos += transform.position;
        return randomPos;
    }

    //61

    public GameObject sfera;
    public int sfere = 20;
    public float radi;
    public float min;
    public float mAx;

    void SpawnSfere()
    {
        for (int i = 0; i < sfere; i++)
        {
            Vector3 randomPos = GetRandomPos2();
            float scale = Random.Range(min, mAx);
            Instantiate(sfera, randomPos, Quaternion.identity);
            new Vector3(scale, randomPos.y, randomPos.z);

        }
    }

    Vector3 GetRandomPos2()
    {
        Vector3 randomPos = Random.insideUnitSphere * radio;
        randomPos.y = 0f;
        randomPos += transform.position;
        return randomPos;
    }

    //63

    public Material[] materiales;
    public GameObject bola;

    //64



    //public Vector3[] pos;

       //pos=new Vector3[]
        //{ new Vector3(0,0,0)}




    */

}




