using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class UIBehavior : MonoBehaviour
{
    private GameObject sheepNumberTxt;
    private GameObject coinNumberTxt;
    // Start is called before the first frame update
    void Start()
    {
        sheepNumberTxt = GameObject.FindGameObjectWithTag("UISheepNumber");
        coinNumberTxt = GameObject.FindGameObjectWithTag("UICoinNumber");
    }

    // Update is called once per frame
    void Update()
    {
        updateSheepText();
        updateCoinText();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toExit();
        }
    }

    private void updateSheepText()
    {
        if (sheepNumberTxt != null)
        {
            sheepNumberTxt.GetComponent<TextMeshProUGUI>().text = ("Sheep: " + GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().sheepNumber);
        }
    }

    private void updateCoinText()
    {
        if (coinNumberTxt != null)
        {
            coinNumberTxt.GetComponent<TextMeshProUGUI>().text = ("Coins: " + GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().coinNumber);
        }
    }

    public void toGamePlayScene()
    {
        SceneManager.LoadScene(1);
    }

    public void toExit()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();
    }
}
