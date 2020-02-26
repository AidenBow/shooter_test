using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour
{
    public GameObject[] explosionPrefabs;
    public int numberOfParticals = 3;
    void Start()
    {
        for(int i = 0; i < numberOfParticals; i++)
        {
            GameObject partical = Instantiate(explosionPrefabs[Random.Range(0, explosionPrefabs.Length)]);
            partical.transform.position = transform.position;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
