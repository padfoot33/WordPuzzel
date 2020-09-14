using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BuyHintsPannelButton : MonoBehaviour
{
    private void Start()
    {
        
        gameObject.GetComponent<Button>().onClick.AddListener(onclick);
    }
    void onclick()
    {
        if(PlayerPrefs.GetInt("Coins") < 1000)
        {
            GameObject Canvas1 = GameObject.Find("Canvas1");
            Instantiate(Resources.Load("InsufficientCoins"), Canvas1.transform);
            StartCoroutine(Deactivate());
            
        }
        else
        {
            GameObject.Find("Canvas1/BuyHintsPannel(Clone)").SetActive(false);
            PlayerPrefs.SetInt("Coins", PlayerPrefs.GetInt("Coins") - 1000);
            PlayerPrefs.SetInt("Hints", PlayerPrefs.GetInt("Hints") + 1);
        }
    }

    IEnumerator Deactivate()
    {
        yield return new WaitForSeconds(3f);
        GameObject.Find("Canvas1/BuyHintsPannel(Clone)").SetActive(false);
        GameObject.Find("Canvas1/InsufficientCoins(Clone)").SetActive(false);
    }
}
