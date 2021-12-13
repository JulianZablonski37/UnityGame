using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Shoot : MonoBehaviour
{
    public Transform firePoint;
    public GameObject bulletPrefab;
    public int bulletCounter=MainMenu.bullet;
    private bool IsRealoading;
    public Text bulletText;
    // Update is called once per frame
    private void Start()
    {
        bulletCounter = MainMenu.bullet;
    }
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
        if(Input.GetButtonDown("Fire2"))
        {
            Debug.Log("Reload");
            StartCoroutine(Reload());
            return;
        } 
        if (GameObject.FindGameObjectsWithTag("Player").Length >= 0)
        {
            bulletText.text = bulletCounter + "/"+MainMenu.bullet;
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
        bulletCounter = MainMenu.bullet;
        IsRealoading = false;
    }   
}
