using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class UiManager : MonoBehaviour
{
    public Text PointT, ComboT, JudgmentT;
    private string X;
    public void PointText(long P, int C, int J)
    {
        X = P.ToString();
        PointT.text = X;
        X = C.ToString();
        if (C > 10)
        {
            ComboT.text = X + "Combo";
        }
        else
        {
            ComboT.text = "";
        }

        if (J == 0)
        {
            JudgmentT.text = "Perfect";
        }
        if (J == 1)
        {
            JudgmentT.text = "Great";
        }
        if (J == 2)
        {
            JudgmentT.text = "Good";
        }
        if (J == 3)
        {
            JudgmentT.text = "Bad";
        }
        if (J == 4)
        {
            JudgmentT.text = "Miss";
        }
        
    }

}
