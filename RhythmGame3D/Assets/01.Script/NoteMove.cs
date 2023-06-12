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
            Judgment.DFJKN(this.gameObject, N);
        } 
        if(this.transform.position.y >= 40)
        {
            JN = true;
        }
    }
}
