using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UiManager : MonoBehaviour
{
    public GameObject NameButton, UpDownButton, BButton;
    public GameObject newObject;
    public Text newText;
    public float px, py, lx, ly, x, y;
    public int T;

    private void Start()    
    {
        y = Screen.height;
        x = Screen.width;
        
        for (int i = 0; i < 3; i++)
        {
            newObject = Instantiate(NameButton, transform);
            newText = newObject.transform.GetChild(0).gameObject.GetComponent<Text>();
            px = -500 / (1920 / x);
            lx = x / 1920;
            ly = y / 1080;
            if (i == 0)
            {
                newText.text = "음악추가";
                py = 180 / (1080 / y);
            }
            else if (i == 1)
            {
                newText.text = "노트추가";
                py = 0;
            }
            else
            {
                newText.text = "설정추가";
                py = -180 / (1080 / y);
            }
            newObject.transform.localPosition = new Vector3 (px, py, 0);
            newObject.transform.localScale = new Vector3(lx, ly, 1);
        }
        for (int i = 0; i < 6; i++)
        {
            newObject = Instantiate(UpDownButton, transform);
            newText = newObject.transform.GetChild(0).gameObject.GetComponent<Text>();

            if (i == 0)
            {
                newText.text = "-";
                px = 450 / (1920 / x);
                py = 180 / (1080 / y);
            }
            else if (i == 1)
            {
                newText.text = "+";
                px = 750 / (1920 / x);
                py = 180 / (1080 / y);
            }
            else if (i == 2)
            {
                newText.text = "-";
                px = 450 / (1920 / x);
                py = 0;
            }
            else if (i == 3)
            {
                newText.text = "+";
                px = 750 / (1920 / x);
                py = 0;
            }
            else if (i == 4)
            {
                newText.text = "-";
                px = 450 / (1920 / x);
                py = -180 / (1080 / y);
            }
            else
            {
                newText.text = "+";
                px = 750 / (1920 / x);
                py = -180 / (1080 / y);
            }
            newObject.transform.localPosition = new Vector3(px, py, 0);
            newObject.transform.localScale = new Vector3(lx, ly, 1);
        }
        newObject = Instantiate(BButton, transform);
        newObject.transform.localPosition = new Vector3(-750 / (1920 / x), 400 / (1080 / y), 0);
        newObject.transform.localScale= new Vector3(lx, ly, 1);
    }

    // Update is called once per frame
    void a()
    {
        
    }
}
