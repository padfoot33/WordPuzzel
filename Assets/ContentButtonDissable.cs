using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ContentButtonDissable : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        disabelAll();
        if (!PlayerPrefs.HasKey("Levels"))
            PlayerPrefs.SetInt("Levels", 0);

        int clearedLevel = PlayerPrefs.GetInt("Levels");
        for(int i = 0; i < clearedLevel + 1; i++)
        {
            transform.GetChild(i).gameObject.GetComponent<Button>().interactable = true;
        }
    }

    public void disabelAll()
    {
        int levelButtonCount = transform.childCount;
        for(int i = 0; i < levelButtonCount; i++)
        {
            transform.GetChild(i).gameObject.GetComponent<Button>().interactable = false;
        }
    }

}
