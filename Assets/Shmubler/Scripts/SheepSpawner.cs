using UnityEngine;
using System.Collections;

public class SheepSpawner : MonoBehaviour
{
    public GameObject[] sheep;
    public float targetTime = 7.0f;

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
        spawnSheep();
        targetTime = Random.Range(5.0f, 10.0f);
    }

    void spawnSheep()
    {
        int temp = Random.Range(0, 5);
        switch(temp)
        {
            case 0:
                Instantiate(sheep[0], new Vector3(Random.Range(80.0f, 90.0f), 0.205f, 67.0f), Quaternion.identity);
                break;
            case 1:
                Instantiate(sheep[1], new Vector3(Random.Range(80.0f, 90.0f), 0.205f, 67.0f), Quaternion.identity);
                break;
            case 2:
                Instantiate(sheep[2], new Vector3(Random.Range(80.0f, 90.0f), 0.205f, 67.0f), Quaternion.identity);
                break;
            case 3:
                Instantiate(sheep[3], new Vector3(Random.Range(80.0f, 90.0f), 0.205f, 67.0f), Quaternion.identity);
                break;
            case 4:
                Instantiate(sheep[4], new Vector3(Random.Range(80.0f, 90.0f), 0.205f, 67.0f), Quaternion.identity);
                break;
        }
    }


}