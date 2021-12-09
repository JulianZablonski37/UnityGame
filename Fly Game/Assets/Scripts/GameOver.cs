using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
  
public class GameOver : MonoBehaviour
{
    public GameObject gameOverPanel;
    public GameObject MainMenuPanel;

    // Update is called once per frame
    void Update()
    { 
        if(GameObject.FindGameObjectsWithTag("Player").Length == 0 && ScoreCounter.score >=1)
        {
            gameOverPanel.SetActive(true);
            MainMenuPanel.SetActive(false);
            ScoreCounter.score = 0;

        }
    }
    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Menu()
    {
        gameOverPanel.SetActive(false);
        MainMenuPanel.SetActive(true);

    }
    public void quit()
    {
        Application.Quit();
    }
}
