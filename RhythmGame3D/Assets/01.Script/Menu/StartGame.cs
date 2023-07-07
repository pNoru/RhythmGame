using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    // Start is called before the first frame update

    public void InGameOnClick()
    {
        Loading.LoadScene("Game");
    }
    public void ExitOnClick()
    {
        Loading.LoadScene("Start");
    }
}
