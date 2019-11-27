using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParticleSpawner : MonoBehaviour
{
    public GameObject Leaves;
    public GameObject Wood;

    [ContextMenu("SpawnLeaves")]
    public void SpawnLeaves()
    {
        GameObject newLeaves = Instantiate(Leaves);
        newLeaves.transform.position = transform.position;
        newLeaves.SetActive(true);
        newLeaves.transform.parent = transform;
        Destroy(newLeaves, 1);
    }

    [ContextMenu("SpawnWood")]
    public void SpawnWood()
    {
        GameObject newLeaves = Instantiate(Wood);
        newLeaves.transform.position = transform.position;
        newLeaves.SetActive(true);
        newLeaves.transform.parent = transform;
        Destroy(newLeaves, 1);
    }

    public void Start()
    {
        SpawnLeaves();
        SpawnWood();

    }
}
