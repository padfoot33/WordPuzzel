using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class SubmitScript : MonoBehaviour
{
    public Text[] text;
    [SerializeField]
    GameObject lvlCompletePannel; 
    [SerializeField]
    GameObject coinsParticals;
    public GameObject[] obj;

    public GameObject[] ObjOrignalPos;
    string completerWord = "";
    public GameObject visualText;

    [SerializeField] private bool isComplete;

    string[] visualWordlist = { "superb!", "awesome!","WOW!","fancy!","lovely!","Good Job!","Brilliant!",
        "Amazing!","Bravo!","Fantastic!","Hooray!","Magnificent!","Unbelievable!" };

    private void Start()
    {
        lvlCompletePannel = Resources.Load("LevelComplete") as GameObject;
        //coinsParticals.AddComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound\\Coin");
        
        //Instantiate(Resources.Load("AmountWon"), lvlCompletePannel.transform);
    }
    public void onSubmitButton()
    {
        
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        visualText.GetComponent<Text>().text = visualWordlist[Random.Range(0, 13)].ToUpper();
        
        //StartCoroutine(waitsec());
        for(int i = 0; i < text.Length; i++)
        {
            completerWord += text[i].GetComponent<Text>().text.ToUpper();
            Debug.Log(completerWord);
        }
        //completerWord = text1.GetComponent<Text>().text + text2.GetComponent<Text>().text + text3.GetComponent<Text>().text;
        Debug.Log(completerWord);
        Debug.Log(AutoGenerateWords.autoWord);

        if (AutoGenerateWords.autoWord == completerWord)
        {
            visualText.SetActive(true);
            
            StartCoroutine(waitsec());
            //AutoGenerateWords auto = new AutoGenerateWords();
            //auto.onSave();
            if(isComplete == false)
            {
                isComplete = true;
                CanvasScript.onSave();     
            }
           
        }
        if (AutoGenerateWords.autoWord != completerWord)
        {
            completerWord = null;
            for (int i = 0; i < obj.Length; i++)
            {
                Vector3 relativeLocation = new Vector3(0, 0, 0);
                Vector3 targetLocation = ObjOrignalPos[i].transform.position + relativeLocation;
                float timeDelta = 0.1f;

                // Start your coroutine
                this.StartCoroutine(MoveLetterBox(targetLocation, timeDelta, i));
            }

        }
    }

    IEnumerator MoveLetterBox(Vector3 target, float delta, int i)
    {
        float closeEnough = 0.2f;
        float distance = (obj[i].transform.position - target).magnitude;

        // GC will trigger unless we define this ahead of time
        WaitForEndOfFrame wait = new WaitForEndOfFrame();

        // Continue until we're there
        while (distance >= closeEnough)
        {
            // Confirm that it's moving
            //Debug.Log("Executing Movement");

            // Move a bit then  wait until next  frame
            obj[i].transform.position = Vector3.Lerp(obj[i].transform.position, target, delta);
            yield return wait;

            // Check if we should repeat
            distance = (obj[i].transform.position - target).magnitude;
        }
    }

    IEnumerator waitsec()
    {
        yield return new WaitForSeconds(2);
        visualText.SetActive(false);
        GameObject clone = (GameObject)GameObject.Instantiate(coinsParticals);
        yield return new WaitForSeconds(3);
        if(isComplete == false)
        {
            GameObject clone1 = Instantiate(lvlCompletePannel, GameObject.Find("Canvas1").transform);
            GameObject.Find("Canvas1/LevelComplete(Clone)").SetActive(true);
            isComplete = true;
        }
        else
        {
            GameObject clone1 = Instantiate(lvlCompletePannel, GameObject.Find("Canvas1").transform);
            GameObject.Find("Canvas1/LevelComplete(Clone)").transform.GetChild(0).gameObject.SetActive(false);
            GameObject.Find("Canvas1/LevelComplete(Clone)").SetActive(true);
        }

        
    }

    /*public void onSave()
    {
        CanvasScript.coins += 100;
        CanvasScript.levels += 1;
        PlayerPrefs.SetInt("Coins", CanvasScript.coins);
        PlayerPrefs.SetInt("Levels", CanvasScript.levels);
    }*/
}
