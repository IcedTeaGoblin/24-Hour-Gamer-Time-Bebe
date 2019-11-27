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
    }

    private void updateSheepText()
    {
        sheepNumberTxt.GetComponent<TextMeshProUGUI>().text = ("Sheep: " + GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().sheepNumber);
    }

    private void updateCoinText()
    {
        coinNumberTxt.GetComponent<TextMeshProUGUI>().text = ("Coins: " + GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().coinNumber);
    }

    public void toGamePlayScene()
    {
        SceneManager.LoadScene(1);
    }
}
