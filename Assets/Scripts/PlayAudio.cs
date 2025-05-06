using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayAudio : MonoBehaviour
{
    private AudioSource source;
    public AudioClip voice;

    private void Start()
    {
        source = GetComponent<AudioSource>();
        source.PlayOneShot(voice);
    }
    // Start is called before the first frame update
    
    private void Update()
    {        

    }
}
