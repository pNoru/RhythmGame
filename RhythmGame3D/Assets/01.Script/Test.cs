using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;

public class Test : MonoBehaviour
{
    public List<string> Data;
    public string source, FilePath;
    void Start()
    {
        FilePath = Application.dataPath + "/08.NSM/data.txt";
        source = File.ReadAllText(FilePath).Replace("\n", string.Empty).Replace(" ", string.Empty); ;
        Data = new List<string>(source.Split(","));
    }

}
