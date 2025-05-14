using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class LetterAdder : MonoBehaviour
{
    //public TextMeshProUGUI letterText;
    private string inputText;
    public GameObject Vault;
    public string password;

    public void GrabFromInput(string input)
    {
        inputText = input.ToLower();
    }
    
    public void ConfirmPassword()
    {
        
        if (inputText == password)
        {
            Debug.Log("You entered the correct password (vagreybore)");
            Vault.GetComponent<Vault>().OpenVault();
        }
    }
}
