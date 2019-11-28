using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaterKat.AudioManager;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Cutscene : MonoBehaviour
{
    public GameObject[] frames;
    private int cutsceneFrame = 0;
    void Update()
    {
        cutsceneBegin(); 
    }

    private void cutsceneBegin()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            cutsceneAdvance();
        }
    }

    private void cutsceneAdvance()
    {
        switch(cutsceneFrame)
        {
            case 0:
                AudioManager.PlaySound("Baa_" + Random.Range(1, 20));
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 1:
                AudioManager.PlaySound("Baa_" + Random.Range(1, 20));
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 2:
                AudioManager.PlaySound("Baa_" + Random.Range(1, 20));
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 3:
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 4:
                AudioManager.PlaySound("Baa_" + Random.Range(1, 20));
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 5:
                AudioManager.PlaySound("Baa_" + Random.Range(1, 20));
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 6:
                AudioManager.PlaySound("Baa_" + Random.Range(1, 20));
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 7:
                AudioManager.PlaySound("Baa_" + Random.Range(1, 20));
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 8:
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 9:
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 10:
                AudioManager.PlaySound("Baa_" + Random.Range(1, 20));
                Destroy(frames[cutsceneFrame]);
                cutsceneFrame++;
                break;
            case 11:
                SceneManager.LoadScene(1); 
                break;
        }
    }
}
