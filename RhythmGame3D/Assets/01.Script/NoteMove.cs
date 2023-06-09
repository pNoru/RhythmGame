using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;


public class NoteMove : MonoBehaviour
{
    public NoteManager NoteManager;
    public Judgment Judgment;
    private GameObject GameObject;
    private int N;
    private bool JN = true;

    private void Update()
    {
        if (this.transform.position.y >= -20)
        {
            transform.Translate(0, -50 * Time.deltaTime, 0);
        }
        else
        {
            Judgment.Delete(N);
        }
        if (this.transform.position.y <= 30 && JN)
        {
            JN = false;
            Judgment = GameObject.Find("GameManager").GetComponent<Judgment>();
            switch (this.transform.position.x)
            {
                case -7.5f:
                    {
                        Judgment.DFJKN(this.gameObject, 0);
                        N = 0;
                        break;
                    }
                case -2.5f:
                    {
                        Judgment.DFJKN(this.gameObject, 1);
                        N = 1;
                        break;
                    }
                case 2.5f:
                    {
                        Judgment.DFJKN(this.gameObject, 2);
                        N = 2;
                        break;
                    }
                case 7.5f:
                    {
                        Judgment.DFJKN(this.gameObject, 3);
                        N = 3;
                        break;
                    }
            }
        } 
        if(this.transform.position.y >= 40)
        {
            JN = true;
        }
    }
}
