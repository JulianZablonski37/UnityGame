using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class ScoreCounter : MonoBehaviour
{
    public Text scoreText;
    public static float score=1;
    // Update is called once per frame
    void Update()
    {
        if(GameObject.FindGameObjectsWithTag("Player").Length >=0)
        {
            score += 1 * Time.deltaTime;
            scoreText.text = ((int)score).ToString(); 
        }
    }
}
