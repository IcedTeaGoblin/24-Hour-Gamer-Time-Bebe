﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using WaterKat.AudioManager;

public class FadeBlack : MonoBehaviour
{
    public void endGame()
    {
        SceneManager.LoadScene(2);
    }
}
