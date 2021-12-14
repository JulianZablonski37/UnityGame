using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public static int health;
    public static int bullet;
    public static int healthv2;
    public static float respownEnemyTime;
    public GameObject MainMenuPanel;
    public GameObject SettingsPanel;
    public static int spownHarderEnemy=20;
    public void settings()
    {
        SettingsPanel.SetActive(true);
        MainMenuPanel.SetActive(false);
    }
    public void playEasyMode()
    {
        bullet = 20;
        spownHarderEnemy = 20;
        health = 50;
        healthv2 = 100;
        respownEnemyTime =1;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void playMediumMode()
    {
        bullet = 15;
        spownHarderEnemy = 10;
        health = 100;
        healthv2 = 150;
        respownEnemyTime = 0.5f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void playHardMode()
    {
        bullet = 15;
        spownHarderEnemy = 5;
        health = 100;
        healthv2 = 200; 
        respownEnemyTime = 0.3f;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void quit()
    {
        Application.Quit(); 
    }
}
