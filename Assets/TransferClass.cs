using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TransferClass : MonoBehaviour
{
    public int Transfer = 0;

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }
}
