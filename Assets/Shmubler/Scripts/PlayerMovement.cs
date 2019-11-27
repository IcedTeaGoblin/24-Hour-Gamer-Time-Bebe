using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    

    // Update is called once per frame
    void Update()
    {
        doMovement();
    }

    private void doMovement()
    {
        if (Input.GetKey(KeyCode.A) && gameObject.transform.position.x > 80.0f)
        {
            Debug.Log("X Position: " + gameObject.transform.position.x);
            gameObject.transform.position += new Vector3(-0.2f, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.D) && gameObject.transform.position.x < 90.0f)
        {
            Debug.Log("X Position: " + gameObject.transform.position.x);
            gameObject.transform.position += new Vector3(0.2f, 0.0f, 0.0f);
        }
    }
}
