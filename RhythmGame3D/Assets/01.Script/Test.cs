using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using System.IO;

public class Test : MonoBehaviour
{

    public GameObject LButton;
    private float R;
    void Start()
    {
        float y = Screen.height;
        R = 1080 / y;
        LButton.transform.localScale = new Vector3(2 / R, 2 / R, 1);
        LButton.transform.localPosition = new Vector3(0, -200, 0);
    }

}
