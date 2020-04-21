using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundTrigger : MonoBehaviour
{
    public AudioSource audioPlayer;
    private bool played = false;
    // Start is called before the first frame update
    void Start()
    {
        audioPlayer = gameObject.GetComponentInChildren<AudioSource>();
    }

    void OnTriggerEnter(Collider other)
    {
        if (!played)
        {
            played = true;
            audioPlayer.Play();
        }
    }
}
