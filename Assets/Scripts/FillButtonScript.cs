using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class FillButtonScript : MonoBehaviour
{
    string text;
    public static GameObject letterBoxPos;
    float speed = 1f;
    public GameObject waitPannel;
    public void onFillButtonTouch()
    {
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        waitPannel.SetActive(true);
        text = CanvasScript.boxLetter;
        Debug.Log("text Coppied " + CanvasScript.boxLetter);

        /*letterBoxPos.transform.position += new Vector3(transform.position.x * speed, 
            transform.position.y * speed, transform.position.z * speed);*/
        /*letterBoxPos.transform.position = Vector3.Lerp(letterBoxPos.transform.position,
            this.transform.position, speed);*/
        gameObject.GetComponentInChildren<Text>().text = text;

        Vector3 relativeLocation = new Vector3(0, 0, 0);
        Vector3 targetLocation = transform.position + relativeLocation;
        float timeDelta = 0.3f;

        // Start your coroutine
        this.StartCoroutine(MoveLetterBox(targetLocation, timeDelta));

    }

    IEnumerator MoveLetterBox(Vector3 target, float delta)
    {
        float closeEnough = 0.2f;
        float distance = (letterBoxPos.transform.position - target).magnitude;

        // GC will trigger unless we define this ahead of time
        WaitForEndOfFrame wait = new WaitForEndOfFrame();

        // Continue until we're there
        while (distance >= closeEnough)
        {
            // Confirm that it's moving
            //Debug.Log("Executing Movement");

            // Move a bit then  wait until next  frame
            letterBoxPos.transform.position = Vector3.Lerp(letterBoxPos.transform.position, target, delta);
            
            yield return wait;
 
            // Check if we should repeat
            distance = (letterBoxPos.transform.position - target).magnitude;
        }
        waitPannel.SetActive(false);
    }

    void Update()
    {

    }
}
