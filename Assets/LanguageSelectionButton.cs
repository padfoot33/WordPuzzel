using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class LanguageSelectionButton : MonoBehaviour
{
    public GameObject LanguagePannel;
    public void onLanguageSelection()
    {
        GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        LanguagePannel.SetActive(false);
        PlayerPrefs.SetString("Language", gameObject.GetComponentInChildren<Text>().text.ToLower());
        Debug.Log(PlayerPrefs.GetString("Language"));
        SceneManager.LoadScene(0);
    }
}
