using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pauseMenuUI;

    private bool isGameInPause = false;

    private void Start()
    {
        Resume();
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape)) 
        {  
            if (isGameInPause) { Resume(); }
            else { Pause(); }
        }
    }
    private void Pause()
    {
        Time.timeScale = 0;
        pauseMenuUI.SetActive(true);
        isGameInPause = true;
    }

    public void Resume() 
    {
        Time.timeScale = 1;
        pauseMenuUI.SetActive(false);
        isGameInPause = false;
    }

    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
