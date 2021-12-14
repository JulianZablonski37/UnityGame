using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownObstacle : MonoBehaviour
{
    public List<GameObject> obstacle;
    private float spawnTime;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
    public int spawnHarderEnemy=MainMenu.spownHarderEnemy;
   
    // Update is called once per frame
    void Update()
    {
        
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnHarderEnemy--;
            spawnTime = Time.time + MainMenu.respownEnemyTime;
        }
       
    }
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        if (spawnHarderEnemy<=0 && ScoreCounter.score>=10)
        {
            spawnHarderEnemy = MainMenu.spownHarderEnemy;
            Instantiate(obstacle[1], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        }
        else if(spawnHarderEnemy <= 0 && ScoreCounter.score >=20)
        { 
            spawnHarderEnemy = (int)(MainMenu.spownHarderEnemy%2);
            Instantiate(obstacle[1], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

        }
        else Instantiate(obstacle[0], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);

    }
}
