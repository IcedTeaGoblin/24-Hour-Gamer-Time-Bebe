using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private GameObject player;
    private GameObject speedControl;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        speedControl = GameObject.FindGameObjectWithTag("SpeedController");
    }

    // Update is called once per frame
    void Update()
    {
        doMovement();
        doDelete();
    }

    private void doMovement()
    {
        gameObject.transform.position += new Vector3(0.0f, 0.0f, speedControl.GetComponent<SpeedControl>().obstacleSpeed);
    }

    private void doDelete()
    {
        if (gameObject.transform.position.z < player.gameObject.transform.position.z - 5)
        {
            Destroy(gameObject);
        }
    }
}
