using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Judgment : MonoBehaviour
{
    private bool Rrr, GD, GF, GJ, GK, UGD, UGF, UGJ, UGK, ND, NF, NJ, NK, TD, TF, TJ, TK;
    public GameObject D, F, J, K;
    public List<GameObject> DNote, FNote, JNote, KNote, LDNote, LFNote, LJNote, LKNote;
    public List<int> SLD, SLF, SLJ, SLK;
    public GameManager GameManager;
    public NoteManager NoteManager;
    private int JN;
    private double Speed;
    public int RSD;

    public void JSetting(int NBPM,int NBeat,float NSpeed)
    {
        Rrr = true;
        double BB = 60d / NBPM / NBeat;
        Speed = 50d * NSpeed * BB;
        ND = false; NF = false; NJ = false; NK = false;
        TD = false; TF = false; TJ = false; TK = false;
    }

    private void Update()
    {
        GD = Input.GetKeyDown(KeyCode.D);
        GF = Input.GetKeyDown(KeyCode.F);
        GJ = Input.GetKeyDown(KeyCode.J);
        GK = Input.GetKeyDown(KeyCode.K);
        UGD = Input.GetKeyUp(KeyCode.D);
        UGF = Input.GetKeyUp(KeyCode.F);
        UGJ = Input.GetKeyUp(KeyCode.J);
        UGK = Input.GetKeyUp(KeyCode.K);

        if (GD)
        {
            D.SetActive(true);
            if (DNote.Count != 0)
            {
                Rrr = true;
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
                else if (Rrr)
                {
                    JN = 4;
                    Rrr = false;
                }
                GameManager.PointJudgment(JN);
                DNote[0].transform.position = new Vector3(0, 400, 0);
                NoteManager.ReturnObjectToQueue(DNote[0]);
                DNote.RemoveAt(0);
                TD = true;
            }
            
            if (LDNote.Count != 0 && !TD)
            {
                Rrr = true;
                double NY = LDNote[0].transform.position.y - ((SLD[0] * Speed) / 2) - 1.5f;
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
                else if (Rrr)
                {
                    JN = 4;
                    Rrr = false;
                }
                ND = true;
                LDNote[0].GetComponent<LongNoteMove>().TNF();
                GameManager.PointJudgment(JN);
            }
        }
        else if (UGD)
        {
            D.SetActive(false);
            if (ND)
            {
                if (LDNote.Count != 0)
                {
                    Rrr = true;
                    double NY = LDNote[0].transform.position.y + ((SLD[0] * Speed) / 2) + 1.5f;
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
                    else if (Rrr)
                    {
                        JN = 4;
                        Rrr = false;
                    }
                    GameManager.PointJudgment(JN);
                }
                LDNote[0].transform.position = new Vector3(0, 400, 0);
                NoteManager.ReturnObjectToQueue(LDNote[0]);
                LDNote.RemoveAt(0);
                SLD.RemoveAt(0);
                ND = false;
            }
            TD = false;
        }

        //FFF
        if (GF)
        {
            F.SetActive(true);

            if (FNote.Count != 0)
            {
                Rrr = true;
                double NFY = FNote[0].transform.position.y;
                JN = 4;
                if (NFY >= 8.5f && NFY <= 11.5f && Rrr)
                {
                    JN = 0;
                    Rrr = false;
                }
                if (NFY >= 7f && NFY <= 13f && Rrr)
                {
                    JN = 1;
                    Rrr = false;
                }
                if (NFY >= 5f && NFY <= 15f && Rrr)
                {
                    JN = 2;
                    Rrr = false;
                }
                if (NFY >= -8f && NFY <= 28f && Rrr)
                {
                    JN = 3;
                    Rrr = false;
                }
                else if (Rrr)
                {
                    JN = 4;
                    Rrr = false;
                }
                GameManager.PointJudgment(JN);
                FNote[0].transform.position = new Vector3(0, 400, 0);
                NoteManager.ReturnObjectToQueue(FNote[0]);
                FNote.RemoveAt(0);
                TF = true;
            }

            if (LFNote.Count != 0 && !TF)
            {
                Rrr = true;
                double NY = LFNote[0].transform.position.y - ((SLF[0] * Speed) / 2) - 1.5f;
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
                else if (Rrr)
                {
                    JN = 4;
                    Rrr = false;
                }
                NF = true;
                LFNote[0].GetComponent<LongNoteMove>().TNF();
                GameManager.PointJudgment(JN);
            }

        }
        else if (UGF)
        {

            F.SetActive(false);

            if (NF)
            {
                if (LFNote.Count != 0)
                {
                    Rrr = true;
                    double NY = LFNote[0].transform.position.y + ((SLF[0] * Speed) / 2) + 1.5f;
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
                    else if (Rrr)
                    {
                        JN = 4;
                        Rrr = false;
                    }
                    GameManager.PointJudgment(JN);
                }
                LFNote[0].transform.position = new Vector3(0, 400, 0);
                NoteManager.ReturnObjectToQueue(LFNote[0]);
                LFNote.RemoveAt(0);
                SLF.RemoveAt(0);
                NF = false;
            }
            TF = false;
        }

        //JJJ
        if (GJ)
        {
            J.SetActive(true);
            if (JNote.Count != 0)
            {
                Rrr = true;
                double NJY = JNote[0].transform.position.y;
                JN = 0;
                if (NJY >= 8.5f && NJY <= 11.5f && Rrr)
                {
                    JN = 0;
                    Rrr = false;
                }
                if (NJY >= 7f && NJY <= 13f && Rrr)
                {
                    JN = 1;
                    Rrr = false;
                }
                if (NJY >= 5f && NJY <= 15f && Rrr)
                {
                    JN = 2;
                    Rrr = false;
                }
                if (NJY >= -8f && NJY <= 28f && Rrr)
                {
                    JN = 3;
                    Rrr = false;
                }
                else if (Rrr)
                {
                    JN = 4;
                    Rrr = false;
                }
                GameManager.PointJudgment(JN);
                JNote[0].transform.position = new Vector3(0, 400, 0);
                NoteManager.ReturnObjectToQueue(JNote[0]);
                JNote.RemoveAt(0);
                TJ = true;
            }
            if (LJNote.Count != 0 && !TJ)
            {
                Rrr = true;
                double NY = LJNote[0].transform.position.y - ((SLJ[0] * Speed) / 2) - 1.5f;
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
                else if (Rrr)
                {
                    JN = 4;
                    Rrr = false;
                }
                NJ = true;
                LJNote[0].GetComponent<LongNoteMove>().TNF();
                GameManager.PointJudgment(JN);
            }

        }
        else if (UGJ)
        {
            J.SetActive(false);
            if (NJ)
            {
                if (LJNote.Count != 0)
                {
                    Rrr = true;
                    double NY = LJNote[0].transform.position.y + ((SLJ[0] * Speed) / 2) + 1.5f;
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
                    else if (Rrr)
                    {
                        JN = 4;
                        Rrr = false;
                    }
                    GameManager.PointJudgment(JN);
                }
                LJNote[0].transform.position = new Vector3(0, 400, 0);
                NoteManager.ReturnObjectToQueue(LJNote[0]);
                LJNote.RemoveAt(0);
                SLJ.RemoveAt(0);
                NJ = false;
            }
            TJ = false;
        }

        //KKK
        if (GK)
        {
            K.SetActive(true);
            if (KNote.Count != 0)
            {
                Rrr = true;
                double NKY = KNote[0].transform.position.y;
                JN = 0;
                if (NKY >= 8.5f && NKY <= 11.5f && Rrr)
                {
                    JN = 0;
                    Rrr = false;
                }
                if (NKY >= 7f && NKY <= 13f && Rrr)
                {
                    JN = 1;
                    Rrr = false;
                }
                if (NKY >= 5f && NKY <= 15f && Rrr)
                {
                    JN = 2;
                    Rrr = false;
                }
                if (NKY >= -8f && NKY <= 28f && Rrr)
                {
                    JN = 3;
                    Rrr = false;
                }
                else if (Rrr)
                {
                    JN = 4;
                    Rrr = false;
                }
                GameManager.PointJudgment(JN);
                KNote[0].transform.position = new Vector3(0, 400, 0);
                NoteManager.ReturnObjectToQueue(KNote[0]);
                KNote.RemoveAt(0);
                TK = true;
            }

            if (LKNote.Count != 0 && !TK)
            {
                Rrr = true;
                double NY = LKNote[0].transform.position.y - ((SLK[0] * Speed) / 2) - 1.5f;
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
                else if (Rrr)
                {
                    JN = 4;
                    Rrr = false;
                }
                NK = true;
                LKNote[0].GetComponent<LongNoteMove>().TNF();
                GameManager.PointJudgment(JN);
            }
        }
        else if (UGK)
        {

            K.SetActive(false);
            if (NK)
            {
                if (LKNote.Count != 0)
                {
                    Rrr = true;
                    double NY = LKNote[0].transform.position.y + ((SLK[0] * Speed) / 2) + 1.5f;
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
                    else if (Rrr)
                    {
                        JN = 4;
                        Rrr = false;
                    }
                    GameManager.PointJudgment(JN);
                }
                LKNote[0].transform.position = new Vector3(0, 400, 0);
                NoteManager.ReturnObjectToQueue(LKNote[0]);
                LKNote.RemoveAt(0);
                SLK.RemoveAt(0);
                NK = false;
            }
            TK = false;
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
    public void LDFJKN(GameObject obj, int n, float S)
    {
        if (n == 0)
        {
            LDNote.Add(obj);
            SLD.Add((int)((S - 3) / Speed));
        }
        if (n == 1)
        {
            LFNote.Add(obj);
            SLF.Add((int)((S - 3) / Speed));
        }
        if (n == 2)
        {
            LJNote.Add(obj);
            SLJ.Add((int)((S - 3) / Speed));
        }
        if (n == 3)
        {
            LKNote.Add(obj);
            SLK.Add((int)((S - 3) / Speed));
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
    public void LDelete(int NN)
    {

        if (NN == 0)
        {
            LDNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.LongReturnObjectToQueue(LDNote[0]);
            LDNote.RemoveAt(0);
        }
        if (NN == 1)
        {
            LFNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.LongReturnObjectToQueue(LFNote[0]);
            LFNote.RemoveAt(0);
        }
        if (NN == 2)
        {
            LJNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.LongReturnObjectToQueue(LJNote[0]);
            LJNote.RemoveAt(0);
        }
        if (NN == 3)
        {
            LKNote[0].transform.position = new Vector3(0, 400, 0);
            NoteManager.LongReturnObjectToQueue(LKNote[0]);
            LKNote.RemoveAt(0);
        }
        GameManager.PointJudgment(4);
    }
}
