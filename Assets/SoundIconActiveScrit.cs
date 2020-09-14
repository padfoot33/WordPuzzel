using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundIconActiveScrit : MonoBehaviour
{
    private void Start()
    {
        if(PlayerPrefs.GetInt("Sound") == 0)
        {
            transform.GetChild(0).gameObject.SetActive(false);
            transform.GetChild(1).gameObject.SetActive(true);
        }
        else
        {
            transform.GetChild(0).gameObject.SetActive(true);
            transform.GetChild(1).gameObject.SetActive(false);
        }
       


    }
}
