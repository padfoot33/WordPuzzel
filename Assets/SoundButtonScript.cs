using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class SoundButtonScript : MonoBehaviour
{
    [SerializeField] GameObject _slider;
    [SerializeField] GameObject _SettingsPannel;

    private void Start()
    {

        gameObject.GetComponent<Button>().onClick.AddListener(onOkButton);
    }
    void onOkButton()
    {
        _SettingsPannel.SetActive(false);
    }
}
