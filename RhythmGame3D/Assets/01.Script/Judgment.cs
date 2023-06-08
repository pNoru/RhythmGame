using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Judgment : MonoBehaviour
{
    private bool DOn, FOn, JOn, KOn;
    public GameObject D, F, J, K;
    private void Start()
    {
        DOn = false; FOn = false; JOn = false; KOn = false;

    }

    private void Update()
    {
        //DDD
        if (Input.GetKey(KeyCode.D))
        {
            if (!DOn)
            {


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
                J.SetActive(true);
                JOn = true;
            }
        }
        else
        {
            J.SetActive(false);
            JOn= false;
        }

        //KKK
        if (Input.GetKey(KeyCode.K))
        {
            if (!KOn)
            {
                K.SetActive(true);
                KOn = true;
            }
        }
        else
        {
            K.SetActive(false);
            KOn = false;
        }
    }
}
