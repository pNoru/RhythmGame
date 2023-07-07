using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{
    public GameObject Judgment, Combo, Point, d, f, j, k;
    private string X;
    public float R;
    private void Start()
    {
        float y = Screen.height;
        R = 1080 / y;
        Combo.transform.localPosition = new Vector3(0, -100 / R, 0);
        Combo.transform.localScale = new Vector3(R, R, 1);
        Judgment.transform.localScale = new Vector3(R, R, 1);
        Point.transform.localPosition = new Vector3(800 / R, 450 / R, 0);
        Point.transform.localScale = new Vector3(R, R, 1);
        d.transform.localPosition = new Vector3(-650 / R, -440 / R, 0);
        f.transform.localPosition = new Vector3(-220 / R, -440 / R, 0);
        j.transform.localPosition = new Vector3(220 / R, -440 / R, 0);
        k.transform.localPosition = new Vector3(650 / R, -440 / R, 0);
        d.transform.localScale = new Vector3(R, R, 1);
        f.transform.localScale = new Vector3(R, R, 1);
        j.transform.localScale = new Vector3(R, R, 1);
        k.transform.localScale = new Vector3(R, R, 1);
    }
    public void PointText(long P, int C, int J)
    {
        X = P.ToString();
        Point.gameObject.GetComponent<Text>().text = X;
        X = C.ToString();
        if (C >= 10)
        {
            Judgment.transform.localPosition = new Vector3(0, 20 / R, 0);
            Combo.gameObject.GetComponent<Text>().text = X + "Combo";
        }
        else
        {
            Judgment.transform.localPosition = new Vector3(0, -40 / R, 0);
            Combo.gameObject.GetComponent<Text>().text = "";
        }

        if (J == 0)
        {
            Judgment.gameObject.GetComponent<Text>().text = "Perfect";
        }
        if (J == 1)
        {
            Judgment.gameObject.GetComponent<Text>().text = "Great";
        }
        if (J == 2)
        {
            Judgment.gameObject.GetComponent<Text>().text = "Good";
        }
        if (J == 3)
        {
            Judgment.gameObject.GetComponent<Text>().text = "Bad";
        }
        if (J == 4)
        {
            Judgment.gameObject.GetComponent<Text>().text = "Miss";
        }
        
    }

}
