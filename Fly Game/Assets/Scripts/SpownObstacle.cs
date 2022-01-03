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
        ScoreCounter.score = Mathf.FloorToInt(ScoreCounter.score);
        if (ScoreCounter.score % 200 == 0 && !Obstaclev3.SpownBos)
        { 
            GameObject[] obstacleList = GameObject.FindGameObjectsWithTag("Enemy");
            foreach(GameObject obstacle in obstacleList)
            {
                Destroy(obstacle);
            }
            Obstaclev3.SpownBos = true;
            Instantiate(obstacle[2], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        } 
        else if (spawnHarderEnemy<=0 && ScoreCounter.score>=10 && !Obstaclev3.SpownBos)
        {
            spawnHarderEnemy = MainMenu.spownHarderEnemy;
            Instantiate(obstacle[1], transform.position + new Vector3(randomX, randomY, 0), transform.rotation);
        }
        else if (!Obstaclev3.SpownBos) Instantiate(obstacle[0], transform.position +new Vector3(randomX, randomY, 0), transform.rotation);

    }
}
