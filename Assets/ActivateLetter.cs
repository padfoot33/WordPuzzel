using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ActivateLetter : MonoBehaviour
{
    [SerializeField]
    GameObject[] activateLetterBox;
    void Start()
    {
        gameObject.GetComponent<Button>().onClick.AddListener(Activate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Activate()
    {
        for(int i = 0; i < activateLetterBox.Length; i++)
        {

            activateLetterBox[i].SetActive(true);
        }
            
    }
}
