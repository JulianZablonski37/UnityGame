using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BulletBoss : MonoBehaviour
{
    public int damage = 50;
    public float speed = 200f;
    private GameObject[] player;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Border")
        {
            Destroy(this.gameObject);
        }
        else if (collision.tag == "Player")
        {
            Obstaclev3.SpownBos = false;
            Destroy(player[0].gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
