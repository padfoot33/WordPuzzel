using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Advertisements;
public class Monatize : MonoBehaviour,IUnityAdsListener
{
    string googlePlay_ID = "3452704";
    bool GameMode = true;
    string myPlacementId = "rewardedVideo";
    void Start()
    {
        Advertisement.AddListener(this);
        Advertisement.Initialize(googlePlay_ID, GameMode);
    }

    public void DisplaInertitialAd()
    {
        Advertisement.Show();
    }

    public void DisplayVideoAd()
    {
        Advertisement.Show(myPlacementId);
    }

    public void OnUnityAdsDidFinish(string placementId, ShowResult showResult)
    {
        // Define conditional logic for each ad completion status:
        if (showResult == ShowResult.Finished)
        {
            print("You get a reward");
        }
        else if (showResult == ShowResult.Skipped)
        {
            print("You didnt get a reward");
        }
        else if (showResult == ShowResult.Failed)
        {
            Debug.LogWarning("The ad did not finish due to an error.");
        }
    }

    public void OnUnityAdsReady(string placementId)
    {
        // If the ready Placement is rewarded, show the ad:
        if (placementId == myPlacementId)
        {
            Advertisement.Show(myPlacementId);
        }
    }

    public void OnUnityAdsDidError(string message)
    {
        // Log the error.
    }

    public void OnUnityAdsDidStart(string placementId)
    {
        // Optional actions to take when the end-users triggers an ad.
    }
}
