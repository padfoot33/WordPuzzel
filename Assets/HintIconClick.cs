using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintIconClick : MonoBehaviour
{
    private void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(onBuyHintButton);
    }

    void onBuyHintButton()
    {
        GameObject Canvas1 = GameObject.Find("Canvas1");
        Instantiate(Resources.Load("BuyHintsPannel"), Canvas1.transform);
    }
}
