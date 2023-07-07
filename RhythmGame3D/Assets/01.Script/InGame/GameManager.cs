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
    private static bool sstart = false, start = true;
    private double CurrentTime;
    private List<string> Data;
    public UiManager UiManager;
    public Judgment Judgment;
    private string BBText;
    private long Point;
    private float Times, Speed;
    private void Start()
    {
        N = 0;
        BBText = File.ReadAllText(Application.dataPath + "/08.NSM/bbdata.txt").Replace("\n", string.Empty).Replace(" ", string.Empty);
        Data = new List<string>(BBText.Split(","));
        BPM = int.Parse(Data[0]); Beat = int.Parse(Data[1]);
        Speed = 1.0f;
        NoteGeneration.Setting(BPM, Beat, Speed);
        Judgment.JSetting(BPM, Beat, Speed);
        start = true;
        Application.Quit();
    }
    public static void IGStart()
    {

        start = true;
    }


    private void Update()
    {
        if (!sstart)
        {
            if (start)
            {
                NoteGeneration.NoteStart();
                StartCoroutine(AudioManager.AudioStart());
                sstart = true;
                tick = Beat;
            }
            if (Input.anyKey && !start)
            {
                NoteGeneration.NoteStart();
                StartCoroutine(AudioManager.AudioStart());
                sstart = true;
                start = true;
                tick = Beat;
            }
        }
        if(start && sstart)
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
        
        UiManager.PointText(Point, Combo, N);
    }
}
