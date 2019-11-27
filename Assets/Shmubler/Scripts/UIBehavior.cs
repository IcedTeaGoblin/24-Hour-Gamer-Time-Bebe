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
    public GameObject fadeBlack;
    public GameObject obstacleHitObject;
    private bool audioMuted = false;
    public AudioMixer mixer;
    private string slider = "MasterVolume";
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
        updateMaxSheepText();
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
            coinNumberTxt.GetComponent<TextMeshProUGUI>().text = (GameObject.FindGameObjectWithTag("SpeedController").GetComponent<SpeedControl>().maxSheepNumber.ToString());
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
    }

    private void unMuteAudio()
    {
        Debug.Log("Audio unMuted");
        mixer.SetFloat(slider, 0.0f);
    }
}
