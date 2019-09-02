using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    public float restartDelay = 1.5f;
    public GameObject completeLevelUI;

    public void CompleteLevel()
    {
        Debug.Log("Level complete");
        completeLevelUI.SetActive(true);
    }


    public void EndGame()
    {
        if (!gameHasEnded) {
            gameHasEnded =  true;
            Debug.Log("Game OVer");
            Invoke("Restart", restartDelay);
        }
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
