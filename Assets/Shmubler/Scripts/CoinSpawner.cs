using UnityEngine;
using System.Collections;

public class CoinSpawner : MonoBehaviour
{
    public GameObject coinObject;
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
        spawnCoin();
        targetTime = Random.Range(1.0f, 3.0f);
    }

    void spawnCoin()
    {
        Instantiate(coinObject, new Vector3(Random.Range(80.0f, 90.0f), 0.205f, 67.0f), Quaternion.identity);
    }


}