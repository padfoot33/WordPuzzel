using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ThemeSelectionScript : MonoBehaviour
{
    private void Start()
    {
        if (!PlayerPrefs.HasKey("Themes"))
            PlayerPrefs.SetInt("Themes", 0);
        //_ThemesObject.transform.GetChild(0).gameObject.SetActive(true);
        for(int i = 0; i < transform.childCount; i++)
        {
            //transform.GetChild(i).gameObject.AddComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound\\Digging");
        }
        if (PlayerPrefs.GetInt("Themes") == 1)
        {
            transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Rock1\\Layer1");
            transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Rock1\\Layer2");
            transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("Rock1\\Layer3");
            transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("Rock1\\Layer4");
        }

        if (PlayerPrefs.GetInt("Themes") == 2)
        {
            transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Rock2\\Layer1");
            transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Rock2\\Layer2");
            transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("Rock2\\Layer3");
            transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("Rock2\\Layer4");
        }

        if (PlayerPrefs.GetInt("Themes") == 3)
        {
            transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("NewSand\\BeachSand_Layer1");
            transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("NewSand\\BeachSand_Layer2");
            transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("NewSand\\BeachSand_Layer3");
            transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("NewSand\\BeachSand_Layer4");
        }
        
        if (PlayerPrefs.GetInt("Themes") == 4)
        {
            transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sand\\Layer1");
            transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sand\\Layer2");
            transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sand\\Layer3");
            transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("Sand\\Layer4");
        }

        if (PlayerPrefs.GetInt("Themes") == 5)
        {
            transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("ColoredRock\\ColoredRock_Layer1");
            transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("ColoredRock\\ColoredRock_Layer2");
            transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("ColoredRock\\ColoredRock_Layer3");
            transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("ColoredRock\\ColoredRock_Layer4");
        }

        if (PlayerPrefs.GetInt("Themes") == 6)
        {
            transform.GetChild(0).GetComponent<Image>().sprite = Resources.Load<Sprite>("StoneWall\\Layer1");
            transform.GetChild(1).GetComponent<Image>().sprite = Resources.Load<Sprite>("StoneWall\\Layer2");
            transform.GetChild(2).GetComponent<Image>().sprite = Resources.Load<Sprite>("StoneWall\\Layer3");
            transform.GetChild(3).GetComponent<Image>().sprite = Resources.Load<Sprite>("StoneWall\\Layer4");
        }
    }
}
