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
        if (Input.GetKey(KeyCode.A) && gameObject.transform.position.x > 81.0f)
        {
            gameObject.transform.position += new Vector3(-0.1f, 0.0f, 0.0f);
        }
        else if (Input.GetKey(KeyCode.D) && gameObject.transform.position.x < 89.0f)
        {
            gameObject.transform.position += new Vector3(0.1f, 0.0f, 0.0f);
        }
    }
}
