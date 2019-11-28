using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LoadTransfer : MonoBehaviour
{
    int score = 0;
    public TextMeshProUGUI textmesh;
    // Start is called before the first frame update
    void Start()
    {
        TransferClass transferClass = FindObjectOfType<TransferClass>();
        if (transferClass != null)
        {
            score = transferClass.Transfer;
            DestroyImmediate(transferClass);
            textmesh.text = "Your Score: " + (-1*score);
        }
        else
        {
            textmesh.text = "";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
