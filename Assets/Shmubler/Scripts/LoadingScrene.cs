using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaterKat.AudioManager;
using UnityEngine.Audio;

public class LoadingScrene : MonoBehaviour
{
    public AudioMixer mixer;
    public GameObject menuScreen;
    private string slider = "MasterVolume";
    public float targetTime = 7.0f;
    private bool timerTriggered = false;
    public bool gameStarted = false;

    // Update is called once per frame
    void Update()
    {

        targetTime -= Time.deltaTime;

        if (targetTime <= 0.0f && timerTriggered == false)
        {
            timerEnded();
        }

    }

    void timerEnded()
    {
        timerTriggered = true;
        endMenu();
    }

    void endMenu()
    { 
        Destroy(menuScreen.gameObject);
        GameObject.FindGameObjectWithTag("UIBehavior").GetComponent<UIBehavior>().fadeIn();
        AudioManager.StopSound("Loading_Music");
        AudioManager.PlaySound("Level_Music");
        gameStarted = true;
    }
}
