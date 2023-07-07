using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SUiManager : MonoBehaviour
{
    public GameObject SButton;
    private float R;
    void Start()
    {
        float y = Screen.height;
        R = 1080 / y;
        SButton.transform.localScale = new Vector3(1 / R, 1 / R, 1);
        SButton.transform.localPosition = new Vector3(-550 / R, -300 / R, 0);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
