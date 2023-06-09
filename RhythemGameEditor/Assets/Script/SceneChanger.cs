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

    public void EOnClick()
    {
        Application.Quit();
    }
}
