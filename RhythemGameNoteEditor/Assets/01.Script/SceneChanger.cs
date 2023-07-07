using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChanger : MonoBehaviour
{
    public void SOnClick()
    {
        SceneManager.LoadScene("InGame");
    }
    public void ROnClick()
    {
        SceneManager.LoadScene("RS");
    }
    public void EOnClick()
    {
        Application.Quit();
    }
    public void Back()
    {
        SceneManager.LoadScene("Start");
    }
}
