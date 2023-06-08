using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public NoteGeneration NoteGeneration;
    public AudioManager AudioManager;
    private bool sstart;
    public double PlayTime;
    
    void Start()
    {
        sstart = false;
    }


    private void Update()
    {
        PlayTime += Time.deltaTime;
        if (!sstart)
        {
            if (Input.anyKey)
            {
                NoteGeneration.NoteStart();
                StartCoroutine(AudioManager.AudioStart());
                sstart = true;
            }
        }
    }
}
