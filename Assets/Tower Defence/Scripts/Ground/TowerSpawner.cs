using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TowerSpawner : MonoBehaviour
{
    // The Monster that should be spawned
    public GameObject enemyPrefab;

    // Spawn Delay in seconds
    public float interval = 3;

    // Use this for initialization
    void Start()
    {
        InvokeRepeating("SpawnNext", interval, interval);
    }

    void SpawnNext()
    {
        Instantiate(enemyPrefab, transform.position, Quaternion.identity);

    }
}
