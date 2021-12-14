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
    public float scoredgold = 0;

    // Update is called once per frame
    void Update()
    {
        scoredgold = ScoreCounter.score;
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
            if(scoredgold - goldv2>=0)
            {
                scoredgold -= goldv2;
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
            if (scoredgold - 100 >= 0)
            {
                scoredgold -= 100;
                bulletNew = true;
                goldText.text = "FULL";
            }
        }
    }
}
