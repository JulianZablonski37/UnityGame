using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int bulletCounter=10;
    private bool IsRealoading;

    // Update is called once per frame
    void Update()
    {
        if (IsRealoading) return;
        if( bulletCounter <=0)
        {
            StartCoroutine(Reload());
            return;
        }
        if(Input.GetButtonDown("Fire1"))
        {
            ShootBullet();
        }
    }
    void ShootBullet()
    {
        bulletCounter--;
        Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
    }
    private IEnumerator Reload()
    {
        IsRealoading = true;
        yield return new WaitForSeconds(1f);
        bulletCounter = 10;
        IsRealoading = false;
    }   
}
