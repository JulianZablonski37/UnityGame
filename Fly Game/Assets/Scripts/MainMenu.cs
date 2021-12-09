using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static int health;
    public static float respownEnemyTime;
    public void playEasyMode()
    {
        health = 50;
        respownEnemyTime =1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void playMediumMode()
    {
        health = 100;
        respownEnemyTime = 0.5f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void playHardMode()
    {
        health = 200;
        respownEnemyTime = 0.3f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quit()
    {
        Application.Quit(); 
    }
}
