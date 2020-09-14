using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AutoGenerateWords : MonoBehaviour
{
    public GameObject[] text;

    public GameObject dirtEffect;

    public GameObject startPannel;

    public Text solutionText;


    
    string[] dialogLines;
    public static string autoWord;
    public int numOfLetters;
    void Start()
    {
        if (!PlayerPrefs.HasKey("Sound"))
        {
            PlayerPrefs.SetInt("Sound", 1);
        }

        hintText();
        BuyHintsButton();

        /*if(startPannelActive == true)
        {
            Time.timeScale = 1;
        }*/
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        for(int i = 0; i < allObjects.Length; i++)
        {
            if (allObjects[i].GetComponent<AudioSource>() != null)
            {
                if (PlayerPrefs.GetInt("Sound") == 0)
                {
                    Debug.Log("Soundon");
                    allObjects[i].GetComponent<AudioSource>().volume = 1;
                }
                if (PlayerPrefs.GetInt("Sound") == 1)
                {
                    Debug.Log("Soundoff");
                    allObjects[i].GetComponent<AudioSource>().volume = 0;
                }
            }
        }

            if (!PlayerPrefs.HasKey("Language"))
            PlayerPrefs.SetString("Language", "english");

        string languageSelected = PlayerPrefs.GetString("Language");

        TextAsset txt = (TextAsset)Resources.Load("Languages\\"+languageSelected);
        //TextAsset txt = (TextAsset)Resources.Load("ospd");
        string[] dict = txt.text.Split('\n');
        Dictionary<int, List<string>> words = new Dictionary<int, List<string>>();
        for (int len = 3; len < 9; len++)
        {
            words[len] = new List<string>();
        }
        foreach (string word in dict)
        {
            int n = word.Length;
            if (n < 9 && n > 2)
            {
                List<string> l = words[n];
                l.Add(word);
            }
        }
        autoWord = words[numOfLetters][Random.Range(200, words.Count)].ToUpper();
        Debug.Log(autoWord);

        for(int i = 0; i < text.Length; i++)
        {
            text[i].GetComponentInChildren<Text>().text += autoWord[i];
            //text[i].AddComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound\\Click");
        }
        dirtEffect.transform.position = new Vector3(320, 100, 248);
        solutionText.GetComponent<Text>().text = autoWord.ToUpper();


        GameObject.Find("Canvas1/Terrain1").AddComponent<ThemeSelectionScript>();
        GameObject.Find("Canvas1/Terrain2").AddComponent<ThemeSelectionScript>();
        GameObject.Find("Canvas1/Terrain3").AddComponent<ThemeSelectionScript>();
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] allObjects = UnityEngine.Object.FindObjectsOfType<GameObject>();
        for (int i = 0; i < allObjects.Length; i++)
        {
            if (allObjects[i].GetComponent<AudioSource>() != null)
            {
                if (PlayerPrefs.GetInt("Sound") == 0)
                {
                    //allObjects[i].AddComponent<AudioCheck>();
                    Debug.Log("Soundon");
                    allObjects[i].GetComponent<AudioSource>().volume = 1;
                }
                if (PlayerPrefs.GetInt("Sound") == 1)
                {
                    Debug.Log("Soundoff");
                    allObjects[i].GetComponent<AudioSource>().volume = 0;
                }
            }
        }
        //coins.text = player.coins.ToString();
        //Debug.Log("coinspannel " + coins.text);
        GameObject.Find("Canvas1/CoinsPannel(Clone)/HintText").GetComponent<Text>().text = PlayerPrefs.GetInt("Hints").ToString();
    }

    void hintText()
    {
        GameObject.Destroy(GameObject.Find("Canvas1/CoinsPannel"));

        if (!PlayerPrefs.HasKey("Hints"))
            PlayerPrefs.SetInt("Hints", 3);
        GameObject canvas = GameObject.Find("Canvas1");
        Instantiate(Resources.Load("CoinsPannel"), canvas.transform);
        
    }

    void BuyHintsButton()
    {
        /*GameObject CoinsPannel = GameObject.Find("Canvas1/CoinsPannel");
        Instantiate(Resources.Load("BuyHints"), CoinsPannel.transform);

        GameObject Canvas1 = GameObject.Find("Canvas1");
        Instantiate(Resources.Load("BuyHintsPannel"), Canvas1.transform);
        GameObject.Find("Canvas1/BuyHintsPannel(Clone)").SetActive(false);
*/
        
        
    }
    
}
