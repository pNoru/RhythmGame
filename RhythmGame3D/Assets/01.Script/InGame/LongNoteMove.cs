using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class LongNoteMove : MonoBehaviour
{
    public Judgment Judgment;
    private int N;
    private bool JN = true, TFN = false;
    private int LN;
    private float NH;

    private void Update()
    {
        if (TFN)
        {
            transform.Translate(0, -25 * Time.deltaTime, 0);
            if (this.transform.localScale.y - 50 * Time.deltaTime >= 0)
            {
                transform.localScale = transform.localScale + new Vector3(0, -50 * Time.deltaTime, 0);
            }
            else
            {
                transform.localScale = new Vector3(4.8f, 0, 0);
            }
        }
        if (this.transform.position.y >= -20 && !TFN)
        {
            transform.Translate(0, -50 * Time.deltaTime, 0);
        }
        else if (this.transform.position.y < -20 && !TFN)
        {
            Judgment.LDelete(N);
        }

        if (this.transform.position.y <= (this.transform.localScale.y / 2) + 30 && JN)
        {
            JN = false;
            Judgment = GameObject.Find("GameManager").GetComponent<Judgment>();
            if (this.transform.position.x == -7.5f)
            {
                N = 0;
            }
            if (this.transform.position.x == -2.5f)
            {
                N = 1;
            }
            if (this.transform.position.x == 2.5f)
            {
                N = 2;
            }
            if (this.transform.position.x == 7.5f)
            {
                N = 3;
            }
            Judgment.LDFJKN(this.gameObject, N, this.transform.localScale.y);
        }

        if (this.transform.position.y >= (this.transform.localScale.y / 2) + 40)
        {
            JN = true;
        }
    }
    public void TNF()
    {
        TFN = true;
    }
    public void SNH(float N)
    {
        NH = N;
    }
}
