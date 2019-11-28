using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaterKat.AudioManager;

public class SheepBehavior : MonoBehaviour
{
    private bool scoreAdded = false;
    private GameObject player;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other = player.gameObject.GetComponent<BoxCollider>())
        {
            if (scoreAdded == false)
            {
                scoreAdded = true;
                AudioManager.PlaySound("Baa_" + Random.Range(1, 24));
                GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().sheepNumber += 1;
                if (GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().sheepNumber >= GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().maxSheepNumber)
                {
                    AudioManager.PlaySound("Woosh");
                    GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().addFOV();
                    GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().obstacleSpeed -= 0.01f;
                    GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().spawnRate *= 0.95f;
                }
                Destroy(gameObject);
            }
        }
    }
}
