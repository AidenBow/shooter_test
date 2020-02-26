using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ExplosionPartical : MonoBehaviour
{
    public float explosionForce = 150f;
    public float lifespan = 1f;
    void Start()
    {
        Vector3 randomDirection = new Vector3(
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f),
            Random.Range(-1f, 1f)
            );

        float randomForce = Random.Range(0f, explosionForce);

        GetComponent<Rigidbody>().AddForce(randomDirection.normalized * randomForce);
    }

    // Update is called once per frame
    void Update()
    {
        lifespan -= Time.deltaTime;
            if (lifespan <= 0)
        {
            Destroy(gameObject);
        }
    }
}
