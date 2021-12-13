using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BulletCounter : MonoBehaviour
{
    public Text bulletText;
    // Update is called once per frame
    void Update()
    {
        if (GameObject.FindGameObjectsWithTag("Player").Length >= 0)
        {
            bulletText.text = MainMenu.bullet+"'\'"+MainMenu.bullet;
        }
    }
}
