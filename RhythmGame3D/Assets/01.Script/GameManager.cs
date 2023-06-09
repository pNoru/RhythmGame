using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using UnityEditor;

public class GameManager : MonoBehaviour
{
    private int N, BPM, Beat, tick, Combo;
    public NoteGeneration NoteGeneration;
    public AudioManager AudioManager;
    private bool sstart, start;
    private double CurrentTime;
    private List<string> Data;
    public UiManager UiManager;
    private string BBText;
    private long Point;
    private float Times;
    public int SSs, Tlqkf;
    private void Awake()
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
    public void End()
    {
        start = false;
    }
    public void PointJudgment(int n)
    {
        Combo += 1;

        if (Combo < 10)
            Times = 1.0f;

        if (Combo >= 10)
            Times = 1.1f;

        if (Combo >= 50)
            Times = 1.2f;

        if (Combo >= 100)
            Times = 1.3f;

        if (Combo >= 150)
            Times = 1.4f;

        if (Combo >= 200)
            Times = 1.5f;

        if (n == 0)
        {
            Point += (int)(200 * Times);
            N = 0;
        }
        if (n == 1)
        {
            Point += (int)(180 * Times);
            N = 1;
        }
        if (n == 2)
        {
            Point += (int)(140 * Times);
            N = 2;
        }
        if (n == 3)
        {
            Point += (int)(80 * Times);
            N = 3;
        }
        if (n == 4)
        {
            N = 4;
            Combo = 0;
        }
        
        SSs = N;
        UiManager.PointText(Point, Combo, N);
    }
}
