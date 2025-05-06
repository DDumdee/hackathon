using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyPickup : MonoBehaviour
{
    public GameObject KeyInventory;
    private Keys KeyInvScript;

    private void Start()
    {
        KeyInvScript = KeyInventory.GetComponent<Keys>();
    }

    public void HideKey()
    {
        Debug.Log("Hiding Key");
        this.gameObject.SetActive(false);
        KeyInvScript.KeyInventory();
    }
}
