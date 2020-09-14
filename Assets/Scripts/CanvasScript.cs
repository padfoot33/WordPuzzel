using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CanvasScript : MonoBehaviour
{
    public GameObject _settingspannel;
    public GameObject StartPannel;
    public GameObject LetterPannel;
    public GameObject CoinsPannel;
    public GameObject TileHolderPannel;
    public GameObject LevelCompletePannel;
    public GameObject LevelsPannel;
    public GameObject SubmitButton;
    public GameObject HintPannel;
    public GameObject HintUnavailablePannel;
    public GameObject LanguagePannel;
    [SerializeField] GameObject ThemesPannel;
    string text;
    public static string boxLetter;
    public Text coinsGui;
    public static int coins;
    public static int levels;
    GameObject buttonAudio;
    
    public void onHintBackButotn()
    {
        HintPannel.SetActive(false);
        HintUnavailablePannel.SetActive(false);
    }
    public void onHintButton()
    {
        if (!StartPannel.activeSelf)
        {
            if (!PlayerPrefs.HasKey("Hints"))
                PlayerPrefs.SetInt("Hints", 3);

            int remainingHints = PlayerPrefs.GetInt("Hints");
            if (remainingHints > 0)
            {
                PlayerPrefs.SetInt("Hints", remainingHints - 1);
                HintPannel.SetActive(true);
            }
            else if (remainingHints <= 0)
            {
                HintUnavailablePannel.SetActive(true);
            }
        }
        
    }
    public static void onSave()
    {
            Debug.Log("Saving Player Data");
            coins = PlayerPrefs.GetInt("Coins") + 100;
            levels = PlayerPrefs.GetInt("Levels") + 1;
            PlayerPrefs.SetInt("Coins", coins);
            PlayerPrefs.SetInt("Levels", levels);
    }

    public void onSteeingsButton()
    {
        _settingspannel.SetActive(true);
    }
    private void Start()
    {
        GameObject.Instantiate(Resources.Load("Audio"));
        
        //GameObject.Instantiate(Resources.Load<AudioSource>("Audio"));
        //GameObject.Find("Audio(Clone)").SetActive(true);
        //PlayerPrefs.DeleteAll();
        /*if (PlayerPrefs.HasKey("Coins"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("Coins", 0);
        }*/
        if (PlayerPrefs.HasKey("Levels"))
        {

        }
        else
        {
            PlayerPrefs.SetInt("Levels", 1);
        }
    }
    public void onPlayButton()
    {
        if(PlayerPrefs.GetInt("Sound") == 0)
        {
            GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        }
            

        /*StartPannel.SetActive(false);
        LetterPannel.SetActive(true);
        CoinsPannel.SetActive(true);
        TileHolderPannel.SetActive(true);
       
        Terrain1.startPannelActive = false;
        LevelsPannel.SetActive(false);
        SubmitButton.SetActive(false);*/
        if (!PlayerPrefs.HasKey("Levels"))
            PlayerPrefs.SetInt("Levels", 1);
        SceneManager.LoadScene(PlayerPrefs.GetInt("Levels"));
        Time.timeScale = 1;
    }

    public void onNextLevelButton()
    {
        GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        LevelCompletePannel.SetActive(false);
        if (PlayerPrefs.GetInt("Levels") > 75 && PlayerPrefs.GetInt("Levels")<100)
        {
            SceneManager.LoadScene(Random.Range(2, 70));
            SubmitButton.SetActive(false);
        }
        else if(PlayerPrefs.GetInt("Levels")<75)
        {
            Scene activetScene = SceneManager.GetActiveScene();
            int BuildIndexOfActiveScene = activetScene.buildIndex;
            SceneManager.LoadScene(BuildIndexOfActiveScene+1);
            Debug.LogError("Next Level = " + levels);
            SubmitButton.SetActive(false);
        }
        
    }

    public void onLanguageButton()
    {
        GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        LanguagePannel.SetActive(true);
        StartPannel.SetActive(false);
        ThemesPannel.SetActive(false);
    }
    
    public void onBackButton()
    {
        GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        /*StartPannel.SetActive(true);
        LetterPannel.SetActive(false);
        CoinsPannel.SetActive(false);
        TileHolderPannel.SetActive(false);
        LevelCompletePannel.SetActive(false);
        LevelsPannel.SetActive(false);
        SubmitButton.SetActive(false);
        ThemesPannel.SetActive(false);*/
        SceneManager.LoadScene(0);
    }
    public void Update()
    {

        GameObject.Find("Canvas1/CoinsPannel(Clone)/Coins").GetComponent<Text>().text = PlayerPrefs.GetInt("Coins").ToString();
    }

    public void onLevelButtonClick()
    {
        GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        LevelsPannel.SetActive(true);
        StartPannel.SetActive(false);
        LetterPannel.SetActive(false);
        CoinsPannel.SetActive(false);
        TileHolderPannel.SetActive(false);
        LevelCompletePannel.SetActive(false);
        ThemesPannel.SetActive(false);
    }

    public void onThemesButton()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        ThemesPannel.SetActive(true);
        LevelsPannel.SetActive(false);
        StartPannel.SetActive(false);
        LetterPannel.SetActive(false);
        CoinsPannel.SetActive(false);
        TileHolderPannel.SetActive(false);
        LevelCompletePannel.SetActive(false);
    }
}
