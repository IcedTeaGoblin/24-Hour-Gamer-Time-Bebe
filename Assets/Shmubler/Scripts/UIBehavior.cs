using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIBehavior : MonoBehaviour
{
    private GameObject sheepNumberTxt;
    // Start is called before the first frame update
    void Start()
    {
        sheepNumberTxt = GameObject.FindGameObjectWithTag("UISheepNumber");
    }

    // Update is called once per frame
    void Update()
    {
        updateText();
    }

    private void updateText()
    {
        sheepNumberTxt.GetComponent<TextMeshProUGUI>().text = ("Sheep: " + GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().sheepNumber);
    }
}
