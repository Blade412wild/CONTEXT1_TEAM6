using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnObject : MonoBehaviour
{
    public Transform Spawnpoint;
    public GameObject Prefab;
    public GameObject DestroyPrefab;

    private void OnTriggerEnter(Collider other)
    {
        Instantiate(Prefab, Spawnpoint.position, Spawnpoint.rotation);
        Destroy(DestroyPrefab);
    }
}
