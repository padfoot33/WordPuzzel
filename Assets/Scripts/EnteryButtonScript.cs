using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class EnteryButtonScript : MonoBehaviour
{
   
    public void onTouch()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        CanvasScript.boxLetter = gameObject.GetComponentInChildren<Text>().text;
        FillButtonScript.letterBoxPos = this.gameObject;
        Debug.Log("Text inserted" + CanvasScript.boxLetter);
    }

}
