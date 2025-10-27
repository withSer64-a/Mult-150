using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioScript : MonoBehaviour
{
    AudioSource audioSource;
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    
    void Update()
    {
        ToggleAudio(audioSource);
    }
    bool ToggleAudio(AudioSource sound)
    {
        if (Input.GetKeyDown(KeyCode.Z))
        {
            if (sound.isPlaying)
            {
                sound.Stop();
                return true;
            }
            else
            {
                sound.Play();
            }
           
        }
        return false;
    }
}
