using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class ThemesScript : MonoBehaviour
{
    [SerializeField] GameObject[] _themes;

    private void Start()
    {
        if (_themes[0].activeSelf)
        {
            gameObject.transform.GetChild(8).gameObject.SetActive(false);
        }
        else
            gameObject.transform.GetChild(8).gameObject.SetActive(true);


        if (_themes[6].activeSelf)
        {
            gameObject.transform.GetChild(7).gameObject.SetActive(false);
        }
        else
            gameObject.transform.GetChild(7).gameObject.SetActive(true);

    }

    private void Update()
    {
        if (_themes[0].activeSelf)
        {
            gameObject.transform.GetChild(8).gameObject.SetActive(false);
        }
        else
            gameObject.transform.GetChild(8).gameObject.SetActive(true);


        if (_themes[6].activeSelf)
        {
            gameObject.transform.GetChild(7).gameObject.SetActive(false);
        }
        else
            gameObject.transform.GetChild(7).gameObject.SetActive(true);
    }
    public void onRight()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        for (int i = 0; i < _themes.Length; i++)
        {
            if (_themes[i].activeSelf)
            {
                _themes[i].SetActive(false);
                _themes[i + 1].SetActive(true);
                break;
            }
        }
    }

    public void onLeft()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        for (int i = 0; i < _themes.Length; i++)
        {
            if (_themes[i].activeSelf)
            {
                _themes[i].SetActive(false);
                _themes[i - 1].SetActive(true);
                break;
            }
        }
    }

    public void onGrass()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("Themes", 0);
        SceneManager.LoadSceneAsync(0);
    }
    public void onMetaRock()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("Themes", 1);
        SceneManager.LoadSceneAsync(0);
    }
    public void onIgneous()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("Themes", 2);
        SceneManager.LoadSceneAsync(0);
    }
    public void onBeachSand()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("Themes", 3);
        SceneManager.LoadSceneAsync(0);
    }
    public void onSand()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("Themes", 4);
        SceneManager.LoadSceneAsync(0);
    }
    public void onColoredRock()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("Themes", 5);
        SceneManager.LoadSceneAsync(0);
    }
    public void onStoneWall()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        PlayerPrefs.SetInt("Themes", 6);
        SceneManager.LoadSceneAsync(0);
    }
}
