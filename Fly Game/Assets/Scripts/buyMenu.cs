using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class buyMenu : MonoBehaviour
{
    public GameObject ResumeMenuUi;
    public GameObject buyMenuUi;
    public Text goldText;
    public static float gold = 100;
    public Text goldv2Text;
    public static float goldv2 = 50;
    public static bool bulletNew=false;

    // Update is called once per frame
    void Update()
    {
        if (!pause.GameIsPaused)
        {
            ResumeMenuUi.SetActive(false);
            buyMenuUi.SetActive(false);
        }
    }
    public void resume()
    {
        ResumeMenuUi.SetActive(true);
        buyMenuUi.SetActive(false);
    }
    public void buyAmmo()
    {
         if(goldv2<=300)
        {
            if(ScoreCounter.score-goldv2>=0)
            {
                ScoreCounter.score -= goldv2;
                goldv2 += 50;
                goldv2Text.text = goldv2.ToString() + "$";
                MainMenu.bullet += 4;
            }
        }
        if(goldv2>=300)
        {
            goldv2Text.text = "FULL";
        }
    }
    public void buyGun()
    {
        if (!bulletNew)
        {
            if (ScoreCounter.score - 100 >= 0)
            {
                ScoreCounter.score -= 100;
                bulletNew = true;
                goldText.text = "FULL";
            }
        }
    }
}
