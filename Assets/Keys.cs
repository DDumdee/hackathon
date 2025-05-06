using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public class Keys : MonoBehaviour
{ 
    public bool keyObtained = false;

    public void KeyInventory()
    {
        this.gameObject.SetActive(true);
        keyObtained = true;
    }

    public void KeyNotInInventory()
    {
        Debug.Log("Key not in inventory");
        this.gameObject.SetActive(false);
        keyObtained = false;
    }
}
