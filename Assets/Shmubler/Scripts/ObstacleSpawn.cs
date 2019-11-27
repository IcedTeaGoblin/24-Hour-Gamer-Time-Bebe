using UnityEngine;
using System.Collections;

public class ObstacleSpawn : MonoBehaviour
{
    public GameObject[] obstacles;
    public float targetTime = 3.0f;

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
        targetTime = Random.Range(1.0f, 3.0f);
    }

    void spawnObstacle()
    {
        
        Instantiate(obstacles[0], new Vector3(Random.Range(80.0f, 90.0f), 1.0f, 67.0f), Quaternion.identity);
    }


}