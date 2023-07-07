using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MUiManager : MonoBehaviour
{
    public GameObject LButton;
    private float R;
    void Start()
    {
        float y = Screen.height;
        R = 1080 / y;
        LButton.transform.localScale = new Vector3(1 / R, 1 / R, 1);
        LButton.transform.localPosition = new Vector3(0, 0, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
