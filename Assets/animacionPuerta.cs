using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animacionPuerta : MonoBehaviour
{
   public Animator anim;
    // Start is called before the first frame update
    void Start()
    {
       
        anim.SetBool("open", false);
        
    }
    private void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("open", true);
            
        }
    }
    private void OnTriggerExit(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            anim.SetBool("open", false);
            
        }
    }

    
    
    
    
    
    public void Cerrar()
    {
        anim.SetBool("open", false);

    }
}
