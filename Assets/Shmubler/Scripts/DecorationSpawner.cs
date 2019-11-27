using UnityEngine;
using System.Collections;

public class DecorationSpawner : MonoBehaviour
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
        targetTime = Random.Range(0.1f, 0.5f) * GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().spawnRate;
    }

    void spawnObstacle()
    {
        int temp = Random.Range(0, 7);
        int temp2 = Random.Range(0, 2);
        switch (temp)
        {
            case 0:
            case 1:
            case 2:
                if (temp2 == 0)
                {
                    Instantiate(obstacles[0], new Vector3(Random.Range(70.0f, 80.0f), 0.284f, 77.0f), Quaternion.identity);
                    break;
                }
                else
                {
                    Instantiate(obstacles[0], new Vector3(Random.Range(90.0f, 100.0f), 0.284f, 77.0f), Quaternion.identity);
                    break;
                }
            case 3:
                if (temp2 == 0)
                {
                    Instantiate(obstacles[1], new Vector3(Random.Range(70.0f, 80.0f), 0.284f, 77.0f), Quaternion.identity);
                    break;
                }
                else
                {
                    Instantiate(obstacles[1], new Vector3(Random.Range(90.0f, 100.0f), 0.284f, 77.0f), Quaternion.identity);
                    break;
                }
            case 4:
                if (temp2 == 0)
                {
                    Instantiate(obstacles[2], new Vector3(Random.Range(70.0f, 80.0f), 0.284f, 77.0f), Quaternion.identity);
                    break;
                }
                else
                {
                    Instantiate(obstacles[2], new Vector3(Random.Range(90.0f, 100.0f), 0.284f, 77.0f), Quaternion.identity);
                    break;
                }
            case 5:
                if (temp2 == 0)
                {
                    Instantiate(obstacles[3], new Vector3(Random.Range(70.0f, 80.0f), 0.284f, 77.0f), Quaternion.identity);
                    break;
                }
                else
                {
                    Instantiate(obstacles[3], new Vector3(Random.Range(90.0f, 100.0f), 0.284f, 77.0f), Quaternion.identity);
                    break;
                }
            case 6:
                if (temp2 == 0)
                {
                    Instantiate(obstacles[4], new Vector3(Random.Range(70.0f, 80.0f), 0.284f, 77.0f), Quaternion.identity);
                    break;
                }
                else
                {
                    Instantiate(obstacles[4], new Vector3(Random.Range(90.0f, 100.0f), 0.284f, 77.0f), Quaternion.identity);
                    break;
                }
        }

    }


}