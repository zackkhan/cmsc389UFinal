using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorChanger : MonoBehaviour {
    public Material material;
    //public AudioSource audioHorse;
    //AudioSource audioSource;
        

    //public void Start()
    //{
    //    audioSource = GetComponent<AudioSource>();
    //    if (audioSource == null)
    //        Debug.Log("audio null");
    //}
    public void pink()
    {
        material.color = new Color(0.8f, 0.2f, 0.6f, 1.0f);
       // audioSource.clip audio;
        //audioHorse.Play();
    }

    public void purple()
    {
        material.color = new Color(0.54f, 0.41f, 0.8f, 1.0f);
    }

    public void red()
    {
        material.color = Color.red;
    }
}
