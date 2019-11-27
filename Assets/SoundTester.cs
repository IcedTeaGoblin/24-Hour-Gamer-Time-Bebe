using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
public class SoundTester : MonoBehaviour
{
    [SerializeField]
    AudioMixer mixer;
    [Range(0,1)]
    public float volumeslider;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        mixer.SetFloat("MasterVolume", volumeslider);    
    }
}
