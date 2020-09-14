using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SountScript : MonoBehaviour
{
    [SerializeField] GameObject _audio;
    [SerializeField] GameObject _soundOffButton;
    [SerializeField] GameObject _soundOnButton;

    private void Start()
    {
        GameObject.Find("Audio(Clone)");
    }
    public void onSoundOn()
    {
        Debug.Log("SoundOn");
        PlayerPrefs.SetInt("Sound", 0);
        _audio.SetActive(true);
        _soundOffButton.SetActive(true);
        _soundOnButton.SetActive(false);
    }
    public void onSoundOff()
    {
        Debug.Log("SoundOff");
        PlayerPrefs.SetInt("Sound", 1);
        _audio.SetActive(false);
        _soundOffButton.SetActive(false);
        _soundOnButton.SetActive(true);
    }
}
