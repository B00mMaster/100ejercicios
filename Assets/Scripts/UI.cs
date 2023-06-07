using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;




public class UI : MonoBehaviour
{
    public GameObject pausePanel;

    
    public Button button;

    public TextMeshProUGUI contadorText;
    public int contador = 0;

    public Image image;
    public float tiempo;
    public int tiempoTotal = 10;

    public Image image2;
    public Slider slider;

    public Renderer rend;
    public Slider slider2;

    public ParticleSystem part;

    public Image vida;
    public float maxVida = 100f;
    public float vidaTotal = 100f;
    public float daño = 10f;

    public GameObject esfera;
    public GameObject cilindro;
    public GameObject cubo;

    public Button boton;
    public Coroutine colorCoroutine;
    public void Esfera()
    {
        esfera.transform.localScale += Vector3.one;
    }


    public void Cubo()
    {
        cubo.transform.localScale += Vector3.one;
    }
    public void Cili()
    {
        cilindro.transform.localScale += Vector3.one;
    }
    public void OnPart()
    {
        part.Play();
    }

   public void OffPart()
    {
        part.Stop();
    }
    void Start()
    {
        tiempo = tiempoTotal;
        StartCoroutine(Tiempo());

        pausePanel.gameObject.SetActive(false);
        button.onClick.AddListener(Panel);

        slider.onValueChanged.AddListener(Image2);
        slider2.onValueChanged.AddListener(Trans);

        boton = GetComponent<Button>();
        boton.onClick.AddListener(OnClick);
        colorCoroutine = StartCoroutine(Coloor());

    }

    IEnumerator Coloor()
    {
        while (true)
        {
            Color newColor = new Color(Random.value, Random.value, Random.value);
            boton.image.color = newColor;
            yield return new WaitForSeconds(1f);
        }
    }

    public void OnClick()
    {
        StopCoroutine(colorCoroutine);
    }
    void PerderVida()
    {
        vidaTotal -= daño;
        
       
    }
    void Trans(float trans)
    {
        Color color = rend.material.color;
        color.a = trans;
        rend.material.color = color;
    }
    void Image2(float slider)
    {
        image2.fillAmount = slider;
    }
    IEnumerator Tiempo()
    {
        while(tiempo>0)
        {
            tiempo -= Time.deltaTime;
            float fillAmount=tiempo/tiempoTotal;
            image.fillAmount = fillAmount;
            yield return null;
        }
    }
    public void Mas()
    {
        contador++;
        ContadorText();

    }

    public void Menos()
    {
        contador--;
        ContadorText();

    }

    void ContadorText()
    {
        contadorText.text = contador.ToString();
    }
   

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.I))
        {
            pausePanel.SetActive(true);
               
        }


        if (Input.GetKeyDown(KeyCode.Space))
        {
            PerderVida();

        }
        float fillAmount = (float)vidaTotal/maxVida;
        vida.fillAmount = fillAmount;
    }

    public void GoScene2()
    {
        SceneManager.LoadScene(1);
    }

    public void GoScene1()
    {
        SceneManager.LoadScene(0);
    }
    void Panel()
    {
        pausePanel.SetActive(false);
    }
 

}
