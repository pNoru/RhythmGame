using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Judgment : MonoBehaviour
{
    private bool DOn, FOn, JOn, KOn, Rrr, Frr, Jrr, Krr;
    public GameObject D, F, J, K;
    public List<GameObject> DNote, FNote, JNote, KNote;
    public GameManager GameManager;
    public NoteManager NoteManager;
    private int JN;
    private void Start()
    {
        DOn = false; FOn = false; JOn = false; KOn = false;
        Rrr = true; Frr = true; Jrr = true; Krr = true;
    }

    private void Update()
    {
        
        if (Input.GetKey(KeyCode.D))
        {
            if (!DOn)
            {
                if (DNote.Count != 0)
                {
                    double NY = DNote[0].transform.position.y;
                    JN = 4;
                    if (NY >= 8.5f && NY <= 11.5f && Rrr)
                    {
                        JN = 0;
                        Rrr = false;
                    }
                    else if (NY >= 7f && NY <= 13f && Rrr)
                    {
                        JN = 1;
                        Rrr = false;
                    }
                    else if (NY >= 5f && NY <= 15f && Rrr)
                    {
                        JN = 2;
                        Rrr = false;
                    }
                    else if (NY >= -8f && NY <= 28f && Rrr)
                    {
                        JN = 3;
                        Rrr = false;
                    }
                    else if(Rrr)
                    {
                        JN = 4;
                        Rrr = false;
                    }
                    GameManager.PointJudgment(JN);
                    DNote[0].transform.position = new Vector3(0, 400, 0);
                    NoteManager.ReturnObjectToQueue(DNote[0]);
                    DNote.RemoveAt(0);
                    Rrr = true;
                }
                
                DOn = true;
                D.SetActive(true);
            }
        }
        else
        {

            D.SetActive(false);
            DOn = false;

        }

        //FFF
        if (Input.GetKey(KeyCode.F))
        {
            if (!FOn)
            {
                if (FNote.Count != 0)
                {
                    double NFY = FNote[0].transform.position.y;
                    JN = 4;
                    if (NFY >= 8.5f && NFY <= 11.5f && Frr)
                    {
                        JN = 0;
                        Frr = false;
                    }
                    if (NFY >= 7f && NFY <= 13f && Frr)
                    {
                        JN = 1;
                        Frr = false;
                    }
                    if (NFY >= 5f && NFY <= 15f && Frr)
                    {
                        JN = 2;
                        Frr = false;
                    }
                    if (NFY >= -8f && NFY <= 28f && Frr)
                    {
                        JN = 3;
                        Frr = false;
                    }
                    else if (Frr)
                    {
                        JN = 4;
                        Frr = false;
                    }
                    GameManager.PointJudgment(JN);
                    FNote[0].transform.position = new Vector3(0, 400, 0);
                    NoteManager.ReturnObjectToQueue(FNote[0]);
                    FNote.RemoveAt(0);
                    Frr = true;
                }

                FOn = true;
                F.SetActive(true);
            }
        }
        else
        {

            F.SetActive(false);
            FOn = false;

        }

        //JJJ
        if (Input.GetKey(KeyCode.J))
        {
            if (!JOn)
            {
                if (JNote.Count != 0)
                {
                    double NJY = JNote[0].transform.position.y;
                    JN = 0;
                    if (NJY >= 8.5f && NJY <= 11.5f && Jrr)
                    {
                        JN = 0;
                        Jrr = false;
                    }
                    if (NJY >= 7f && NJY <= 13f && Jrr)
                    {
                        JN = 1;
                        Jrr = false;
                    }
                    if (NJY >= 5f && NJY <= 15f && Jrr)
                    {
                        JN = 2;
                        Jrr = false;
                    }
                    if (NJY >= -8f && NJY <= 28f && Jrr)
                    {
                        JN = 3;
                        Jrr = false;
                    }
                    else if (Jrr)
                    {
                        JN = 4;
                        Jrr = false;
                    }
                    GameManager.PointJudgment(JN);
                    JNote[0].transform.position = new Vector3(0, 400, 0);
                    NoteManager.ReturnObjectToQueue(JNote[0]);
                    JNote.RemoveAt(0);
                    Jrr = true;
                }

                JOn = true;
                J.SetActive(true);
            }
        }
        else
        {

            J.SetActive(false);
            JOn = false;

        }

        //KKK
        if (Input.GetKey(KeyCode.K))
        {
            if (!KOn)
            {
                if (KNote.Count != 0)
                {
                    double NKY = KNote[0].transform.position.y;
                    JN = 0;
                    if (NKY >= 8.5f && NKY <= 11.5f && Krr)
                    {
                        JN = 0;
                        Krr = false;
                    }
                    if (NKY >= 7f && NKY <= 13f && Krr)
                    {
                        JN = 1;
                        Krr = false;
                    }
                    if (NKY >= 5f && NKY <= 15f && Krr)
                    {
                        JN = 2;
                        Krr = false;
                    }
                    if (NKY >= -8f && NKY <= 28f && Krr)
                    {
                        JN = 3;
                        Krr = false;
                    }
                    else if (Krr)
                    {
                        JN = 4;
                        Krr = false;
                    }
                    GameManager.PointJudgment(JN);
                    KNote[0].transform.position = new Vector3(0, 400, 0);
                    NoteManager.ReturnObjectToQueue(KNote[0]);
                    KNote.RemoveAt(0);
                    Krr = true;


                }

                KOn = true;
                K.SetActive(true);
            }
        }
        else
        {

            K.SetActive(false);
            KOn = false;

        }
    }

    public void DFJKN(GameObject obj, int n)
    {

        if (n == 0) 
        {
            DNote.Add(obj);
        }
        if (n == 1)
        {
            FNote.Add(obj);
        }
        if (n == 2)
        {
            JNote.Add(obj);
        }
        if (n == 3)
        {
            KNote.Add(obj);
        }
    }
    public void Delete(int NN)
    {
        
        if (NN == 0)
        {
            DNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.ReturnObjectToQueue(DNote[0]);
            DNote.RemoveAt(0);
        }
        if (NN == 1)
        {
            FNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.ReturnObjectToQueue(FNote[0]);
            FNote.RemoveAt(0);
        }
        if (NN == 2)
        {
            JNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.ReturnObjectToQueue(JNote[0]);
            JNote.RemoveAt(0);
        }
        if (NN == 3)
        {
            KNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.ReturnObjectToQueue(KNote[0]);
            KNote.RemoveAt(0);
        }
        GameManager.PointJudgment(4);
    }
}
