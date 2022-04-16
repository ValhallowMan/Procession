using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuBatton : MonoBehaviour
{
    public void GameStart(int index)
    {
        SceneManager.LoadScene(index);
    }

    public void GameExit()
    {
        Application.Quit();
    }
}
