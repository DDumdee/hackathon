using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Vault : MonoBehaviour
{
    public GameObject VaultClosed;
    public GameObject VaultOpened1;
    public GameObject VaultOpened2;

    public void OpenVault()
    {
        VaultClosed.SetActive(false);
        VaultOpened1.SetActive(true);
        VaultOpened2.SetActive(true);
        this.gameObject.SetActive(false);
    }
    
}
