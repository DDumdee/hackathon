using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CageUnlock : MonoBehaviour
{
    public GameObject KeyInventory;
    private Keys KeyInvScript;

    private void Start()
    {
        KeyInvScript = KeyInventory.GetComponent<Keys>();
    }

    public void UnlockCage()
    {
        if (KeyInvScript.keyObtained)
        {
            Debug.Log("Cage Unlocked");
            KeyInvScript.KeyNotInInventory();
            this.gameObject.SetActive(false);
        }
        else
        {
            Debug.Log("You need a key");
        }
    }
}
