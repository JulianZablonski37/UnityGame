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
        Obstacle enemy = collision.GetComponent<Obstacle>();
        if(enemy != null)
        {
            enemy.TakeDamage(damage);
        }
        Destroy(gameObject);    
    }
}