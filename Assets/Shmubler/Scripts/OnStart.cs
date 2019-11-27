using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnStart : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject.FindGameObjectWithTag("UIBehavior").GetComponent<UIBehavior>().fadeIn();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
