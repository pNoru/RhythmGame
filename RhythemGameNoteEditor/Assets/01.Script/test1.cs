using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class test1 : MonoBehaviour
{
    public ObjPooling ObjPooling;
    public GameObject ObjPool;
    public void NOn()
    {
        ObjPool = ObjPooling.GetNote();
        ObjPool.transform.localPosition = new Vector3(100, 100, 0);
    }
    public void LOn()
    {
        ObjPool = ObjPooling.GetLine();
        ObjPool.transform.localPosition = new Vector3(300, 0, 0);
    }

    public void BOn()
    {
        ObjPool = ObjPooling.GetBON();
        ObjPool.transform.localPosition = new Vector3(-300, -100, 0);
    }
}
