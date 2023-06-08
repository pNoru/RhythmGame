using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NoteGeneration : MonoBehaviour
{
    private int N;
    private double CurrentTime;
    public GameObject Note;
    public GameObject LongNoteRail;
    public GameManager GameManager;
    private List<string> Data;
    private string source;
    private void Start()
    {
        N = 0;
        source = File.ReadAllText(Application.dataPath + "/08.NSM/data.txt").Replace("\n", string.Empty).Replace(" ", string.Empty);
        Data = new List<string>(source.Split(","));
    }

    public void NoteStart()
    {
        if (Data[N * 4] == string.Empty)
        {
            GameManager.end();
        }
        else
        {
            Generation(Data.GetRange(N * 4, 4));
            N += 1;
        }
    }

    private void Generation(List<string> NG)
    {
        if (int.Parse(NG[0]) == 1)
        {
            Instantiate(Note, new Vector3(-7.5f, 400, -0.02f), Quaternion.identity);
        }
        if (int.Parse(NG[1]) == 1)
        {
            Instantiate(Note, new Vector3(-2.5f, 400, -0.02f), Quaternion.identity);
        }
        if (int.Parse(NG[2]) == 1)
        {
            Instantiate(Note, new Vector3(2.5f, 400, -0.02f), Quaternion.identity);
        }
        if (int.Parse(NG[3]) == 1)
        {
            Instantiate(Note, new Vector3(7.5f, 400, -0.02f), Quaternion.identity);
        }
    }
}

