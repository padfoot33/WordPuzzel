using System.Collections;
using UnityEngine;
using UnityEngine.UI;
public class Terrain1 : MonoBehaviour
{
    public GameObject dirtEffect;
    public GameObject cam;
    public GameObject terrain2;
    public static bool startPannelActive;
    void Start()
    {
        if(gameObject.GetComponent<AudioSource>() == null)
        {
            gameObject.AddComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound\\Digging");
        }
        Application.targetFrameRate = 60;
        //gameObject.GetComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound\\Digging");
    }

    // Update is called once per frame
    void Update()
    {
/*        if (Input.touchCount > 0)
        {
            string name = gameObject.name;
            Debug.Log(name);
            dirtEffect.SetActive(true);
            dirtEffect.transform.position += new Vector3(0, -10, 0);
            GameObject clone = (GameObject)GameObject.Instantiate(dirtEffect);
            cam.transform.position += new Vector3(0, -10, 0);

            StartCoroutine(Wait(clone));
            Destroy(gameObject);
            terrain2.SetActive(true);
        }*/
        
    }

    public void OnMouseDown()
    {
        if (startPannelActive == false)
        {
            onTouch();
            
        } 
    }

    public void onTouch()
    {
        /*if (PlayerPrefs.GetInt("Sound") == 1)
        {
            gameObject.GetComponent<AudioSource>().Play();
        }*/
        
        string name = gameObject.name;
        Debug.Log(name);
        dirtEffect.SetActive(true);
        dirtEffect.transform.position += new Vector3(0, -10, 0);
        GameObject clone = (GameObject)GameObject.Instantiate(dirtEffect);
        cam.transform.position += new Vector3(0, -10, 0);

        StartCoroutine(Wait(clone));
        Destroy(gameObject);
        terrain2.SetActive(true);
    }
    IEnumerator Wait(GameObject clone)
    {
        yield return new WaitForSeconds(1.5f);
        Destroy(clone);
        
    }
}
