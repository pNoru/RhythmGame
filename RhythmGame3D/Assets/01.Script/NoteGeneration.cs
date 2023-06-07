using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NoteGeneration : MonoBehaviour
{
    private int N, BPM;
    private double CurrentTime;
    public GameObject Note;
    public GameObject LongNoteRail;
    private List<string> Data;
    private string source, FilePath;
    private void Start()
    {
        N = 0;
        FilePath = Application.dataPath + "/08.NSM/data.txt";
        source = File.ReadAllText(FilePath).Replace("\n", string.Empty).Replace(" ", string.Empty); ;
        Data = new List<string>(source.Split(","));
    }

    private void Update()
    {
        
    }

    void Generation(List<string> NG)
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

