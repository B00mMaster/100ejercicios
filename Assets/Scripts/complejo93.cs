using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class complejo93 : MonoBehaviour
{
    public Animator ani;

    int animationState;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }

    public void NextAnimation()
    {
       
        
        
        animationState++;
        if(animationState >=ani.runtimeAnimatorController.animationClips.Length)
        {
            animationState = 0;

        }

        ani.SetInteger("AnimationState", animationState);
    }

    public void PreviousAnimation()
    {
        animationState--;
        if(animationState < 0)
        {
            animationState = ani.runtimeAnimatorController.animationClips.Length-1;
        }

        ani.SetInteger("AnimationState", animationState);
    }

   public void RandomAnimation()
    {
        animationState = Random.Range(0, ani.runtimeAnimatorController.animationClips.Length);

        ani.SetInteger("AnimationState", animationState);
    }
}
