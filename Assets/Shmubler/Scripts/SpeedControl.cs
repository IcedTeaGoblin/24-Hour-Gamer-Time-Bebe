using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SpeedControl : MonoBehaviour
{
    public float spawnRate = 1.0f;
    public float obstacleSpeed;
    public int sheepNumber = 3;
    public int maxSheepNumber;
    public float pointNumber;

    private void Update()
    {
        if (sheepNumber > maxSheepNumber)
        {
            maxSheepNumber = sheepNumber;
        }

        if (sheepNumber < 0)
        {
            gameLost();
        }

        if (GameObject.FindGameObjectWithTag("LoadingScreen").GetComponent<LoadingScrene>().gameStarted == true)
        {
            pointNumber += (obstacleSpeed - (sheepNumber / 10));
        }
    }


    public void addFOV()
    {
        for (int i = 0; i < 5; i++)
        {
            Camera.main.fieldOfView += 0.1f;
        }
    }

    public void gameLost()
    {
        spawnRate = 0.0f;
        obstacleSpeed = 0.0f;
        GameObject.FindGameObjectWithTag("UIBehavior").GetComponent<UIBehavior>().fadeOut();
    }
}
