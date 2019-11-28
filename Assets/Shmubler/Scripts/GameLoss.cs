using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WaterKat.AudioManager;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;
public class GameLoss : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        AudioManager.PlaySound("GameOver_Music");
    }
    public void restart()
    {
        SceneManager.LoadScene(1);
    }
}
