using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaterKat.AudioManager;

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

        if (Input.GetKeyDown(KeyCode.B))
        {
            AudioManager.PlaySound("Baa_" + Random.Range(1, 24));
        }
    }
}
