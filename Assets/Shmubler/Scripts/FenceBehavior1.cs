using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FenceBehavior1 : MonoBehaviour
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
            Instantiate(gameObject, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z + 0.75f), gameObject.transform.rotation);
        }
    }
}
