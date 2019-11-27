using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpeedControl : MonoBehaviour
{
    public float spawnRate = 1.0f;
    public float obstacleSpeed;
    public int sheepNumber;
    public int maxSheepNumber;
    public int coinNumber;

    private void Update()
    {
        if (sheepNumber > maxSheepNumber)
        {
            maxSheepNumber = sheepNumber;
        }
    }
}
