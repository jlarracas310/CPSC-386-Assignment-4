using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ReturnToMenu : MonoBehaviour
{
    // Return to Title Screen
    public void GoToMenu()
    {
        Time.timeScale = 1f;
        AudioListener.pause = false;  // Resume audio
        SceneManager.LoadScene(0);
    }
}