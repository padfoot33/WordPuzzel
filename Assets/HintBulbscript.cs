using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class HintBulbscript : MonoBehaviour
{
    GameObject canvas;
    [SerializeField] GameObject StartPannel;
    [SerializeField] GameObject HintPannel;
    [SerializeField] GameObject HintUnavailablePannel;
    void Start()
    {
        /*GameObject[] allObjs = Object.FindObjectsOfType<GameObject>();
        for (int i = 0; i < allObjs.Length; i++)
            allObjs[i].SetActive(true);*/

        canvas = GameObject.Find("Canvas1");
        StartPannel = canvas.transform.Find("StartScreenPannel").gameObject;
        HintPannel = canvas.transform.Find("HintPannel").gameObject;
        HintUnavailablePannel = canvas.transform.Find("HintUnavailablePannel").gameObject;
        gameObject.GetComponent<Button>().onClick.AddListener(onHint);

        /*for (int i = 0; i < allObjs.Length; i++)
            allObjs[i].SetActive(false);*/
    }

    public void onHint()
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
}
