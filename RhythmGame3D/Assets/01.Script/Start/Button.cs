using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    // Start is called before the first frame update
    public void StartOnClick()
    {
        SceneManager.LoadScene("Menu");
    }
    public void EndOnClick()
    {
        Application.Quit();
    }
}
