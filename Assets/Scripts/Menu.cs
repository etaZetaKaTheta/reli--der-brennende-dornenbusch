using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    public AudioMixer mixer;

    public void LoadTerrain()
    {
        SceneManager.LoadScene(1);
    }

    public void SetMasterVolume(float value)
    {
        mixer.SetFloat("masterVolume", value);
    }
}
