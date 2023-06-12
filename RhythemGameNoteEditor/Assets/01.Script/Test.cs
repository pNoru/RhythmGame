using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    public float y;
    // Start is called before the first frame update
    void Start()
    {
        y = Screen.height;
    }

    // Update is called once per frame
    public void OnTest()
    {
        Debug.Log("start");
        StartCoroutine("DelayTime");
        Debug.Log("end");
    }
    public IEnumerator DelayTime()
    {
        yield return new WaitForSeconds(10f);
        Debug.Log("end");
    }
}
