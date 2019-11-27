﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinBehavior : MonoBehaviour
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
                GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().coinNumber += 1;
                Destroy(gameObject);
            }
        }
    }
}
