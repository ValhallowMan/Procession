using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class PlayerDie : MonoBehaviour
{
    public GameObject player;
    public GameObject DieMenuUI;
    public PlayerOptions playerOptions;

    public void PlayerDieStart()
    {
            PlayerDieAnimation();
            DieMenu();
    }

    private void PlayerDieAnimation()
    {
        Destroy(player);
    }
    private void DieMenu()
    {
        Time.timeScale = 0f;
        DieMenuUI.SetActive(true);
    }
    public void RestartGame()
    {
        SceneManager.LoadScene(1);
    }
    public void ExitToMenu()
    {
        SceneManager.LoadScene(0);
    }
}
