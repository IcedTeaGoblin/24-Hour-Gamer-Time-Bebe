using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundBehavior : MonoBehaviour
{
    public GameObject clone;
    private bool spawned = false;

    void Update()
    {
        spawnTile();
    }

    private void spawnTile()
    {
        if (spawned == false && gameObject.transform.position.z < 90.0f)
        {
            spawned = true;
            Instantiate(clone, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 9.0f), gameObject.transform.rotation);
        }
    }
}
