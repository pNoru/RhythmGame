using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public AudioSource metronome;
    private void Start()
    {
        metronome.clip = Resources.Load("ticktock") as AudioClip;
        audioSource.clip = Resources.Load("aaa") as AudioClip;
    }
    public IEnumerator AudioStart()
    {
        yield return new WaitForSeconds(5.8f);
        audioSource.Play();
    }
    public IEnumerator TickTock()
    {
        yield return new WaitForSeconds(6.9f);
        metronome.Play();
    }
}
