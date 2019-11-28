using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;
using WaterKat.AudioManager;
using UnityEngine.Audio;

public class UIBehavior : MonoBehaviour
{
    private GameObject sheepNumberTxt;
    private GameObject coinNumberTxt;
    private GameObject pointNumberTxt;
    public GameObject fadeBlack;
    public GameObject obstacleHitObject;
    private GameObject muteButton;
    private bool audioMuted = false;
    public AudioMixer mixer;
    private string slider = "MasterVolume";
    public Sprite[] muteUnMute;

    // Start is called before the first frame update
    void Start()
    {
        sheepNumberTxt = GameObject.FindGameObjectWithTag("UISheepNumber");
        coinNumberTxt = GameObject.FindGameObjectWithTag("UICoinNumber");
        pointNumberTxt = GameObject.FindGameObjectWithTag("UIPointNumber");
        muteButton = GameObject.FindGameObjectWithTag("MuteButton");
    }

    // Update is called once per frame
    void Update()
    {
        updateSheepText();
        updateMaxSheepText();
        updatePointsText();
        muteHotKey();

        if (Input.GetKeyDown(KeyCode.Escape))
        {
            toExit();
        }

    }

    private void updateSheepText()
    {
        if (sheepNumberTxt != null)
        {
            sheepNumberTxt.GetComponent<TextMeshProUGUI>().text = (GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().sheepNumber.ToString());
        }
    }

    private void updateMaxSheepText()
    {
        if (coinNumberTxt != null)
        {
            coinNumberTxt.GetComponent<TextMeshProUGUI>().text = ("MPH: " + (10 + GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().maxSheepNumber * 5).ToString());
        }
    }

    private void updatePointsText()
    {
        if (pointNumberTxt != null)
        {
            pointNumberTxt.GetComponent<TextMeshProUGUI>().text = ("Score: " + (Mathf.Floor(GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().pointNumber) * -1).ToString());
        }
    }

    public void toGamePlayScene()
    {
        SceneManager.LoadScene(3);
    }

    public void toExit()
    {
        Debug.Log("Exiting Game...");
        Application.Quit();
    }

    public void fadeIn()
    {
        fadeBlack.GetComponent<Animator>().Play("FadeIn");
    }

    public void fadeOut()
    {
        fadeBlack.GetComponent<Animator>().Play("FadeOut");
    }

    public void obstacleHit()
    {
        obstacleHitObject.GetComponent<Animator>().Play("ObstacleHitSignal");
    }

    public void muteHotKey()
    {
        if (Input.GetKeyDown(KeyCode.M))
        {
            changeAudio();
        }
    }

    public void changeAudio()
    {
        if (audioMuted)
        {
            unMuteAudio();
            audioMuted = false;
        }
        else
        {
            muteAudio();
            audioMuted = true;
        }
    }

    private void muteAudio()
    {
        Debug.Log("Audio Muted");
        mixer.SetFloat(slider, -80.0f);
        muteButton.GetComponent<SpriteRenderer>().sprite = muteUnMute[0];
    }

    private void unMuteAudio()
    {
        Debug.Log("Audio unMuted");
        mixer.SetFloat(slider, 0.0f);
        muteButton.GetComponent<SpriteRenderer>().sprite = muteUnMute[1];
    }
}
