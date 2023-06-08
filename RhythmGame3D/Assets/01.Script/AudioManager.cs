using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class AudioManager : MonoBehaviour
{
    public AudioSource audioSource;
    public int s;
    public IEnumerator AudioStart()
    {
        s = 2;
        audioSource.clip = Resources.Load("aaa") as AudioClip;
        yield return new WaitForSeconds(6f);
        audioSource.Play();
    }
    public void TickTock()
    {

    }
}
