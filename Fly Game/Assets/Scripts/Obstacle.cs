using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Obstacle : MonoBehaviour
{
    private int health = MainMenu.health;
    private GameObject[] player;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if(health <= 0)
        {
            ScoreCounter.score+=2;
            Die();
        }
    }
    private void Die()
    {
        Destroy(gameObject);
    }
  private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if(collision.tag == "Player")
        {
            Destroy(player[0].gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
