using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using Unity.VisualScripting;

public class NoteGeneration : MonoBehaviour
{
    private int N, BPM, Beat;
    private bool start;
    private double CurrentTime;
    public GameObject Note;
    public GameObject LongNoteRail;
    private List<string> Data;
    private string source, BBText;
    public AudioManager AudioManager;
    private void Start()
    {
        N = 0;
        start = false;
        BBText = File.ReadAllText(Application.dataPath + "/08.NSM/bbdata.txt").Replace("\n", string.Empty).Replace(" ", string.Empty);
        source = File.ReadAllText(Application.dataPath + "/08.NSM/data.txt").Replace("\n", string.Empty).Replace(" ", string.Empty);
        Data = new List<string>(BBText.Split(","));
        BPM = int.Parse(Data[0]); Beat = int.Parse(Data[1]);
        Data = new List<string>(source.Split(","));
    }

    private void Update()
    {
        if (Data[N] == string.Empty)
        {
            start = false;
        }
        if (start)
        {
            CurrentTime += Time.deltaTime;
            
            if(CurrentTime >= 60d / BPM / Beat)
            {
                Generation(Data.GetRange(N * 4, (N * 4) + 4));
                CurrentTime -= 60d / BPM / Beat;
                N += 1;
            }
        }
    }

    private void Generation(List<string> NG)
    {
        if (int.Parse(NG[0]) == 1)
        {
            Instantiate(Note, new Vector3(-7.5f, 800, 0), Quaternion.identity);
        }
        if (int.Parse(NG[1]) == 1)
        {
            Instantiate(Note, new Vector3(-2.5f, 800, 0), Quaternion.identity);
        }
        if (int.Parse(NG[2]) == 1)
        {
            Instantiate(Note, new Vector3(2.5f, 800, 0), Quaternion.identity);
        }
        if (int.Parse(NG[3]) == 1)
        {
            Instantiate(Note, new Vector3(7.5f, 800, 0), Quaternion.identity);
        }
    }
}

