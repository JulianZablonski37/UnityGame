using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public int damage = 50;
    public float speed = 200f;
    public Rigidbody2D rb;

    // Update is called once per frame
    void Start ()
    {
        rb.velocity = transform.right * speed ;
    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (buyMenu.bulletNew) damage *= 2;
        Obstacle enemy = collision.GetComponent<Obstacle>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);
        Obstaclev2 enemyv2 = collision.GetComponent<Obstaclev2>();
        if (enemyv2 != null)
        {
            enemyv2.TakeDamage(damage);
        }
        Destroy(gameObject); 
        Obstaclev3 enemyv3 = collision.GetComponent<Obstaclev3>();
        if (enemyv3 != null)
        {
            enemyv3.TakeDamage(damage);
        }
        Destroy(gameObject);
    }
}
