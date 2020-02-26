using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject bulletPrefab;
    void Start()
    {
        
    }

    void Update()
    {
        if (Input.GetMouseButton(0)){
            GameObject bulletObj = Instantiate(bulletPrefab);
            Bullet bullet = bulletObj.GetComponent<Bullet>();

            Vector3 shootingDirection = new Vector3(-1f, Random.Range(-.1f, .5f), Random.Range(-.5f, .5f));
            bullet.shootingDirection = shootingDirection.normalized; 
        }
    }
}
