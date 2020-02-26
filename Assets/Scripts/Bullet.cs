using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    public float shootingForce = 1500f;
    public Vector3 shootingDirection;
    public float lifespan = 3f;
    public GameObject ExplosionPrefab;
    void Start()
    {
        GetComponent<Rigidbody>().AddForce(shootingDirection * shootingForce);
    }

    void Update()
    {
        lifespan -= Time.deltaTime;
        if  (lifespan <= 0)
        {
            Destroy(gameObject);
        }
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "TriggerExplosion")
        {
            GameObject newExplosion = Instantiate(ExplosionPrefab);
            newExplosion.transform.position = transform.position;
        }
    }
}
