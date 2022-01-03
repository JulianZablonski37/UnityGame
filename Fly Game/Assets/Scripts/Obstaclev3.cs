using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Obstaclev3 : MonoBehaviour
{
    // Start is called before the first frame update
    public static bool SpownBos=false;
    public GameObject bulletPrefab;
    private int health = MainMenu.healthv2;
    private GameObject[] player;
    public Transform firePoint;
    public bool spawnBullet = true; 
    void Start()
    {
        player = GameObject.FindGameObjectsWithTag("Player");
    }
    public void Update()
    {
        if(this && player[0])
        {
            Vector3 oldPositon = Vector3.Lerp(transform.position, player[0].transform.position, Time.deltaTime);
            transform.position = new Vector3(player[0].transform.position.x + 15, oldPositon.y, 0);
        }
        if(SpownBos)
        {
            if(spawnBullet)
            { 
                StartCoroutine(ShootBullet());
            }
            else return;
        }

    }
    public void TakeDamage(int damage)
    {
        health -= damage;
        if (health <= 0)
        {
            ScoreCounter.score += 10;
            Die();
        }
    }
    private void Die()
    {
        SpownBos = false;
        Destroy(gameObject);
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            Destroy(player[0].gameObject);
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
    private IEnumerator ShootBullet()
    {
        spawnBullet = false;
        GameObject bullet = Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
        yield return new WaitForSeconds(1f);
        spawnBullet = true;
    }
}
