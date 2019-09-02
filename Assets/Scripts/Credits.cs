using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Credits : MonoBehaviour
{
    public void MainMenu()
    {
        // load menu scene
        SceneManager.LoadScene(0);
    }

    public void Quit()
    {
        Debug.Log("QUIT");
        Application.Quit();
    }

}
