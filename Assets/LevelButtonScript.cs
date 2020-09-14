using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
public class LevelButtonScript : MonoBehaviour
{
    [SerializeField]
    GameObject LevelsPannel;

    private void Start()
    {
        this.GetComponent<Button>().onClick.AddListener(LevelButtonClick);
    }
    void LevelButtonClick()
    {
        GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        LevelsPannel.SetActive(false);
        int lvlNum = int.Parse(this.gameObject.GetComponentInChildren<Text>().text);
        if (lvlNum>=75 && lvlNum <= 100)
        {
            SceneManager.LoadScene(Random.Range(2,70));
        }
        else if (lvlNum < 75)
        {
            SceneManager.LoadScene(lvlNum);
        }
    }
}
