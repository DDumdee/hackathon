using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberAdder : MonoBehaviour
{
    public TextMeshProUGUI numberText;
    public GameObject Vault;
    private List<int> numbers = new List<int>();
    public int password;
    
    public void AddNumber(int number)
    {
        if (numbers == null || numbers.Count <= 3)
        {
            numbers.Add(number);
            Debug.Log("Number Count: " + numbers.Count);
        }
        else
        {
            Debug.Log("You can't add more than 4 numbers");
            Debug.Log("Number Count: " + numbers.Count);
        }

        string text = "";
        for (int i = 0; i < numbers.Count; i++)
        {
            text += numbers[i];
        }

        numberText.text = text;
    }

    public void ClearNumbers()
    {
        numbers.Clear();
        numberText.text = "    \\oWo/";
    }

    public void ConfirmNumber()
    {
        string text = "";
        for (int i = 0; i < numbers.Count; i++)
        {
            text += numbers[i];
        }
        int number = int.Parse(text);
        if (number == password)
        {
            Debug.Log("You entered the correct password (9898)");
            Vault.GetComponent<Vault>().OpenVault();
        }
    }
}
