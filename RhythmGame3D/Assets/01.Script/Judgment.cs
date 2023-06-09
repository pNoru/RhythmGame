using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Judgment : MonoBehaviour
{
    private bool DOn, FOn, JOn, KOn, Rrr, Frr, Jrr, Krr;
    public GameObject D, F, J, K;
    public List<GameObject> DNote, FNote, JNote, KNote;
    private double NY, NFY, NJY, NKY;
    public GameManager GameManager;
    public NoteManager NoteManager;
    public int NS, JUdd;
    public List<double> NSYL;
    private void Start()
    {
        DOn = false; FOn = false; JOn = false; KOn = false;
        Rrr = true; Frr = true; Jrr = true; Krr = true;
    }

    private void Update()
    {
        //DDD
        if (Input.GetKey(KeyCode.D))
        {
            if (!DOn)
            {
                if (DNote.Count != 0)
                {
                    NY = DNote[0].transform.position.y;
                    NSYL.Add(NY);
                    JUdd += 1;
                    if (NY >= 8.5f && NY <= 11.5f && Rrr)
                    {
                        GameManager.PointJudgment(0);
                        DNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(DNote[0]);
                        DNote.RemoveAt(0);
                        Rrr = false;
                    }
                    if (NY >= 7f && NY <= 13f && Rrr)
                    {
                        GameManager.PointJudgment(1);
                        DNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(DNote[0]);
                        DNote.RemoveAt(0);
                        Rrr = false;
                    }
                    if (NY >= 5f && NY <= 15f && Rrr)
                    {
                        GameManager.PointJudgment(2);
                        DNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(DNote[0]);
                        DNote.RemoveAt(0);
                        Rrr = false;
                    }
                    if (NY >= -8f && NY <= 28f && Rrr)
                    {
                        GameManager.PointJudgment(3);
                        DNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(DNote[0]);
                        DNote.RemoveAt(0);
                        Rrr = false;
                    }
                    else if(Rrr)
                    {
                        GameManager.PointJudgment(4);
                        DNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(DNote[0]);
                        DNote.RemoveAt(0);
                        Rrr = false;
                    }
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
                    NFY = FNote[0].transform.position.y;
                    NSYL.Add(NFY);
                    if (NFY >= 8.5f && NFY <= 11.5f && Frr)
                    {
                        GameManager.PointJudgment(0);
                        FNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(FNote[0]);
                        FNote.RemoveAt(0);
                        Frr = false;
                    }
                    if (NFY >= 7f && NFY <= 13f && Frr)
                    {
                        GameManager.PointJudgment(1);
                        FNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(FNote[0]);
                        FNote.RemoveAt(0);
                        Frr = false;
                    }
                    if (NFY >= 5f && NFY <= 15f && Frr)
                    {
                        GameManager.PointJudgment(2);
                        FNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(FNote[0]);
                        FNote.RemoveAt(0);
                        Frr = false;
                    }
                    if (NY >= -8f && NY <= 28f && Frr)
                    {
                        GameManager.PointJudgment(3);
                        FNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(FNote[0]);
                        FNote.RemoveAt(0);
                        Frr = false;
                    }
                    else if (Frr)
                    {
                        GameManager.PointJudgment(4);
                        FNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(FNote[0]);
                        FNote.RemoveAt(0);
                        Frr = false;
                    }
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

                    NJY = JNote[0].transform.position.y;
                    NSYL.Add(NJY);
                    if (NJY >= 8.5f && NJY <= 11.5f && Jrr)
                    {
                        GameManager.PointJudgment(0);
                        JNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(JNote[0]);
                        JNote.RemoveAt(0);
                        Jrr = false;
                    }
                    if (NJY >= 7f && NJY <= 13f && Jrr)
                    {
                        GameManager.PointJudgment(1);
                        JNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(JNote[0]);
                        JNote.RemoveAt(0);
                        Jrr = false;
                    }
                    if (NJY >= 5f && NJY <= 15f && Jrr)
                    {
                        GameManager.PointJudgment(2);
                        JNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(JNote[0]);
                        JNote.RemoveAt(0);
                        Jrr = false;
                    }
                    if (NJY >= -8f && NJY <= 28f && Jrr)
                    {
                        GameManager.PointJudgment(3);
                        JNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(JNote[0]);
                        JNote.RemoveAt(0);
                        Jrr = false;
                    }
                    else if (Jrr)
                    {
                        GameManager.PointJudgment(4);
                        JNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(JNote[0]);
                        JNote.RemoveAt(0);
                        Jrr = false;
                    }
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
                    NKY = KNote[0].transform.position.y;
                    NSYL.Add(NKY);
                    if (NKY >= 8.5f && NKY <= 11.5f && Krr)
                    {
                        GameManager.PointJudgment(0);
                        KNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(KNote[0]);
                        KNote.RemoveAt(0);
                        Krr = false;
                    }
                    if (NKY >= 7f && NKY <= 13f && Krr)
                    {
                        GameManager.PointJudgment(1);
                        KNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(KNote[0]);
                        KNote.RemoveAt(0);
                        Krr = false;
                    }
                    if (NKY >= 5f && NKY <= 15f && Krr)
                    {
                        GameManager.PointJudgment(2);
                        KNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(KNote[0]);
                        KNote.RemoveAt(0);
                        Krr = false;
                    }
                    if (NKY >= -8f && NKY <= 28f && Krr)
                    {
                        GameManager.PointJudgment(3);
                        KNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(KNote[0]);
                        KNote.RemoveAt(0);
                        Krr = false;
                    }
                    else if (Krr)
                    {
                        GameManager.PointJudgment(4);
                        KNote[0].transform.position = new Vector3(0, 400, 0);
                        NoteManager.ReturnObjectToQueue(KNote[0]);
                        KNote.RemoveAt(0);
                        Krr = false;
                    }
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
            GameManager.PointJudgment(4);
            DNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.ReturnObjectToQueue(DNote[0]);
            DNote.RemoveAt(0);
        }
        if (NN == 1)
        {
            GameManager.PointJudgment(4);
            FNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.ReturnObjectToQueue(FNote[0]);
            FNote.RemoveAt(0);
        }
        if (NN == 2)
        {
            GameManager.PointJudgment(4);
            JNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.ReturnObjectToQueue(JNote[0]);
            JNote.RemoveAt(0);
        }
        if (NN == 3)
        {
            GameManager.PointJudgment(4);
            KNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.ReturnObjectToQueue(KNote[0]);
            KNote.RemoveAt(0);
        }
    }
}
