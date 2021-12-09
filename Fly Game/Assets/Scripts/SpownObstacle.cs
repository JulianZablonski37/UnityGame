using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpownObstacle : MonoBehaviour
{
    public GameObject obstacle;
    private float spawnTime;
    public float minX;
    public float minY;
    public float maxX;
    public float maxY;
   
    // Update is called once per frame
    void Update()
    {
        if(Time.time > spawnTime)
        {
            Spawn();
            spawnTime = Time.time + MainMenu.respownEnemyTime;
        }
       
    }
    void Spawn()
    {
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);

        Instantiate(obstacle,transform.position+new Vector3(randomX,randomY,0),transform.rotation);
    }
}
