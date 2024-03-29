﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaterKat.AudioManager;

public class ObstacleBehavior : MonoBehaviour
{
    private bool scoreAdded = false;
    private GameObject player;
    public string hitSound;
    public int sheepLoss;
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        if (gameObject.transform.position.z == player.transform.position.z + 20.0f && gameObject.name == "(Obs) Farmer1")
        {
            AudioManager.PlaySound("Human_" + Random.Range(1, 12));
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other = player.gameObject.GetComponent<BoxCollider>())
        {
            if (scoreAdded == false)
            {
                scoreAdded = true;
                AudioManager.PlaySound(hitSound);
                GameObject.FindGameObjectWithTag("UIBehavior").GetComponent<UIBehavior>().obstacleHit();
                GameObject.FindGameObjectWithTag("ScreenShake").GetComponent<ScreenShake>().shake(0.2f);
                GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().sheepNumber -= sheepLoss;
                Destroy(gameObject);
            }
        }
    }
}
