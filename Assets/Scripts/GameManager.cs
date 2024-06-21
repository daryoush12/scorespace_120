using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using LootLocker;
using LootLocker.Requests;
using System;

public class GameManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        LootLockerSDKManager.StartGuestSession(SessionStarted);
    }

    private void SessionStarted(LootLockerSessionResponse res) {
        if (res.success)
        {
            Debug.Log("Session started successfully!");
        }
        else Debug.LogError(String.Format("Error: {0}", res.errorData));
    }
}

