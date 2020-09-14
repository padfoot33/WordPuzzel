using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuThemesScript : MonoBehaviour
{
    [SerializeField] GameObject _ThemesObject;
    private void Start()
    {
        if (!PlayerPrefs.HasKey("Themes"))
            PlayerPrefs.SetInt("Themes", 0);

        //_ThemesObject.transform.GetChild(0).gameObject.SetActive(true);
        if (PlayerPrefs.GetInt("Themes") == 0)
        {
            _ThemesObject.transform.GetChild(0).gameObject.SetActive(true);
            _ThemesObject.transform.GetChild(1).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(2).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(3).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(4).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(5).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(6).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Themes") == 1)
        {
            _ThemesObject.transform.GetChild(0).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(1).gameObject.SetActive(true);
            _ThemesObject.transform.GetChild(2).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(3).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(4).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(5).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(6).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Themes") == 2)
        {
            _ThemesObject.transform.GetChild(0).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(1).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(2).gameObject.SetActive(true);
            _ThemesObject.transform.GetChild(3).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(4).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(5).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(6).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Themes") == 3)
        {
            _ThemesObject.transform.GetChild(0).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(1).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(2).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(3).gameObject.SetActive(true);
            _ThemesObject.transform.GetChild(4).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(5).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(6).gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Themes") == 4)
        {
            _ThemesObject.transform.GetChild(0).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(1).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(2).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(3).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(4).gameObject.SetActive(true);
            _ThemesObject.transform.GetChild(5).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(6).gameObject.SetActive(false);
        }

        if (PlayerPrefs.GetInt("Themes") == 5)
        {
            _ThemesObject.transform.GetChild(0).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(1).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(2).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(3).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(4).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(5).gameObject.SetActive(true);
            _ThemesObject.transform.GetChild(6).gameObject.SetActive(false);
        }
        if (PlayerPrefs.GetInt("Themes") == 6)
        {
            _ThemesObject.transform.GetChild(0).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(1).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(2).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(3).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(4).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(5).gameObject.SetActive(false);
            _ThemesObject.transform.GetChild(6).gameObject.SetActive(true);
        }
    }
}
