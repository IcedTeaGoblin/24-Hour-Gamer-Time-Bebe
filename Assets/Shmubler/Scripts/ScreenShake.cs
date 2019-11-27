using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenShake : MonoBehaviour
{
    public Transform target;
    private Vector3 initialPosition;

    void Start()
    {
        initialPosition = target.localPosition;
    }

    public float shakeDuration = 0.1f;

    public void shake(float duration)
    {
        if (duration > 0)
        {
            shakeDuration += duration;
        }
    }

    private bool isShaking = false;
    // Update is called once per frame
    void Update()
    {
        if (shakeDuration > 0 && !isShaking)
        {
            StartCoroutine(DoShake());
        }
    }

    IEnumerator DoShake()
    {
        isShaking = true;

        var StartTime = Time.realtimeSinceStartup;
        while (Time.realtimeSinceStartup < StartTime + shakeDuration)
        {
            var randomPoint = new Vector3(initialPosition.x + Random.Range(-0.1f, 0.1f), initialPosition.y + Random.Range(-0.1f, 0.1f), initialPosition.z);
            target.localPosition = randomPoint;
            yield return null;
        }

        target.localPosition = initialPosition;
        shakeDuration = 0.0f;
        isShaking = false;
    }
}
