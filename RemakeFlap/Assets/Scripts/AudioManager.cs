using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    [SerializeField] AudioSource effectAudioSource;
    [SerializeField] AudioClip dieClip;
    [SerializeField] AudioClip jumpClip;
    [SerializeField] AudioClip pointClip;
    
    public void PlayDieSound()
    {
        effectAudioSource.PlayOneShot(dieClip);
    }
    public void PlayJumpSound()
    {
        effectAudioSource.PlayOneShot(jumpClip);
    }
    public void PlayPointSound()
    {
        effectAudioSource.PlayOneShot(pointClip);
    }
}
