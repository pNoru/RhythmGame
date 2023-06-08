using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class GameManager : MonoBehaviour
{
    public int N, BPM, Beat, tick;
    public NoteGeneration NoteGeneration;
    public AudioManager AudioManager;
    private bool sstart, start;
    public double CurrentTime;
    public List<string> Data;
    private string BBText;

    void Start()
    {
        N = 0;
        BBText = File.ReadAllText(Application.dataPath + "/08.NSM/bbdata.txt").Replace("\n", string.Empty).Replace(" ", string.Empty);
        sstart = false; start = false;
        Data = new List<string>(BBText.Split(","));
        BPM = int.Parse(Data[0]); Beat = int.Parse(Data[1]);
    }


    private void Update()
    {
        if (!sstart)
        {
            if (Input.anyKey)
            {
                NoteGeneration.NoteStart();
                StartCoroutine(AudioManager.AudioStart());
                sstart = true;
                start = true;
                tick = Beat;
            }
        }
        if(start)
        {
            CurrentTime += Time.deltaTime;
            if (CurrentTime >= 60d / BPM / Beat)
            {
                CurrentTime -= 60d / BPM / Beat;
                NoteGeneration.NoteStart();
                if (tick == Beat)
                {
                    StartCoroutine(AudioManager.TickTock());
                    tick -= Beat;
                }
                else
                {
                    tick += 1;
                }
            }
        }
    }
    public void end()
    {
        start = false;
    }
}
