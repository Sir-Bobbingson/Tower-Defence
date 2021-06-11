using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ValidSpawnPoint : MonoBehaviour
{
    public GameObject towerPrefab;

    void OnMouseUpAsButton()
    {
        // Build Tower above Buildplace
        GameObject g = (GameObject)Instantiate(towerPrefab);
        g.transform.position = transform.position + Vector3.up;
    }
}
