using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class complejo91: MonoBehaviour
{
    public AudioClip[] audio;

    public Color[] color;

    public AudioSource audioSource;
    public Camera camera;

    private void Start()
    {
        audioSource = GetComponent<AudioSource>();
        camera = Camera.main;
    }

    private void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            RandomAudio();
            RandomColor();
        }
    }

    void RandomAudio()
    { if(audio.Length==0) return;

        int random = Random.Range(0, audio.Length);
        audioSource.PlayOneShot(audio[random]);
    }

    void RandomColor()
    {
        if (color.Length == 0) return;

        int random = Random.Range(0, color.Length);
        camera.backgroundColor= color[random];
    }
}
