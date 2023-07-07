using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

public class NoteGeneration : MonoBehaviour
{
    private int N;
    private GameObject Note;
    public GameManager GameManager;
    public NoteManager NoteManager;
    private List<string> Data;
    private string source;
    private double Speed;
    private void Start()
    {
        N = 0;
        source = File.ReadAllText(Application.dataPath + "/08.NSM/data.txt").Replace("\n", string.Empty).Replace(" ", string.Empty);
        Data = new List<string>(source.Split(","));
    }
    public void Setting(int NBPM, int NBeat, float NSpeed)
    {
        double BB = 60d / NBPM / NBeat;
        Speed = 50d * NSpeed * BB;
    }
    public void NoteStart()
    {
        if (Data[N * 4] == "-1")
        {
            GameManager.End();
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
            Note = NoteManager.GetObject();
            Note.transform.position = new Vector3(-7.5f, 400, -0.02f);
        }
        else if (int.Parse(NG[0]) != 0)
        {
            Note = NoteManager.LongGetObject();
            Note.transform.position = new Vector3(-7.5f, 400 + ((float)((int.Parse(NG[0]) - 1) * Speed) / 2), -0.02f);
            Note.transform.localScale = new Vector3(4.8f, (float)((int.Parse(NG[0]) - 1) * Speed) + 3, 0.01f);
        }
        if (int.Parse(NG[1]) == 1)
        {
            Note = NoteManager.GetObject();
            Note.transform.position = new Vector3(-2.5f, 400, -0.02f);
        }
        else if (int.Parse(NG[1]) != 0)
        {

            Note = NoteManager.LongGetObject();
            Note.transform.position = new Vector3(-2.5f, 400 + ((float)((int.Parse(NG[1]) - 1) * Speed) / 2), -0.02f);
            Note.transform.localScale = new Vector3(4.8f, (float)((int.Parse(NG[1]) - 1) * Speed) + 3, 0.01f);

        }
        if (int.Parse(NG[2]) == 1)
        {
            Note = NoteManager.GetObject();
            Note.transform.position = new Vector3(2.5f, 400, -0.02f);
        }
        else if (int.Parse(NG[2]) != 0)
        {

            Note = NoteManager.LongGetObject();
            Note.transform.position = new Vector3(2.5f, 400 + ((float)((int.Parse(NG[2]) - 1) * Speed) / 2), -0.02f);
            Note.transform.localScale = new Vector3(4.8f, (float)((int.Parse(NG[2]) - 1) * Speed) + 3, 0.01f);

        }
        if (int.Parse(NG[3]) == 1)
        {
            Note = NoteManager.GetObject();
            Note.transform.position = new Vector3(7.5f, 400, -0.02f);
        }
        else if (int.Parse(NG[3]) != 0)
        {

            Note = NoteManager.LongGetObject();
            Note.transform.position = new Vector3(7.5f, 400 + ((float)((int.Parse(NG[3]) - 1) * Speed) / 2), -0.02f);
            Note.transform.localScale = new Vector3(4.8f, (float)((int.Parse(NG[3]) - 1) * Speed) + 3, 0.01f);
            Note.GetComponent<LongNoteMove>().SNH((float)((int.Parse(NG[3]) - 1) * Speed) + 3);
        }
    }
}

