using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class GrabText : MonoBehaviour
{
    public GameObject letterCollecterbutton;

    private void Start()
    {
        gameObject.AddComponent<AudioSource>().clip = Resources.Load<AudioClip>("Sound\\Click");
        gameObject.GetComponent<AudioSource>().Stop();
    }
    public void OnGrab()
    {
        gameObject.GetComponent<AudioSource>().Play();
        //GameObject.Find("Audio(Clone)").GetComponent<AudioSource>().Play();
        Transform textComponent = transform.GetChild(0);
        textComponent.GetComponent<Animator>().SetBool("Scale", true);
        
        StartCoroutine(waitForSeconds());
    }

    IEnumerator waitForSeconds()
    {
        Debug.Log("Coroutine Called");
        yield return new WaitForSeconds(1);
        letterCollecterbutton.SetActive(true);
        letterCollecterbutton.GetComponentInChildren<Text>().text = transform.GetComponentInChildren<Text>().text.ToUpper();
        Destroy(gameObject);

    }

    /*public GameObject targetPos;
    float speed = 1f;
    public GameObject waitPannel;
    public void onClick()
    {
        // Get the target position
        Vector3 relativeLocation = new Vector3(0, -10, 0);
        Vector3 targetLocation = targetPos.transform.position + relativeLocation;
        float timeDelta = 0.05f;

        // Start your coroutine
        this.StartCoroutine(SmoothMove(targetLocation, timeDelta));
    }

    IEnumerator SmoothMove(Vector3 target, float delta)
    {
        // Will need to perform some of this process and yield until next frames
        float closeEnough = 0.2f;
        float distance = (targetPos.transform.position - target).magnitude;

        // GC will trigger unless we define this ahead of time
        WaitForEndOfFrame wait = new WaitForEndOfFrame();

        // Continue until we're there
        while (distance >= closeEnough)
        {
            // Confirm that it's moving
            //Debug.Log("Executing Movement");

            // Move a bit then  wait until next  frame
            transform.position = Vector3.Slerp(targetPos.transform.position, target, delta);
            yield return wait;

            // Check if we should repeat
            distance = (targetPos.transform.position - target).magnitude;
        }

        // Complete the motion to prevent negligible sliding
        targetPos.transform.position = target;

        // Confirm  it's ended
        Debug.Log("Movement Complete");
    }*/
}
