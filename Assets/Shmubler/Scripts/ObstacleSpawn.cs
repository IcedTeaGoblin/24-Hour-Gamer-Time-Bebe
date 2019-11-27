using UnityEngine;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] obstacles;
    private float targetTime = 9.0f;

    private void Start()
    {
    }

    void Update()
    {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        spawnObstacle();
        targetTime = Random.Range(0.1f, 1.0f) * GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().spawnRate;
    }

    void spawnObstacle()
    {
        int temp = Random.Range(0, 8);
        switch(temp)
        {
            case 0:
            case 1:
            case 2:
                Instantiate(obstacles[0], new Vector3(Random.Range(81.0f, 89.0f), 0.719f, 7.0f), Quaternion.identity);
                break;
            case 3:
                Instantiate(obstacles[1], new Vector3(Random.Range(81.0f, 89.0f), 0.71f, 77.0f), Quaternion.identity);
                break;
            case 4:
                Instantiate(obstacles[2], new Vector3(Random.Range(81.0f, 89.0f), 0.338f, 77.0f), Quaternion.identity);
                break;
            case 5:
                Instantiate(obstacles[3], new Vector3(Random.Range(81.0f, 89.0f), 0.169f, 77.0f), Quaternion.identity);
                break;
            case 6:
                Instantiate(obstacles[4], new Vector3(Random.Range(81.0f, 89.0f), 0.234f, 77.0f), Quaternion.identity);
                break;
            case 7:
                Instantiate(obstacles[5], new Vector3(Random.Range(81.0f, 89.0f), 0.57f, 77.0f), Quaternion.identity);
                break;
        }
    
    }


}