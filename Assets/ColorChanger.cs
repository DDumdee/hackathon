using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColorChanger : MonoBehaviour
{
    public Image scriptImg;
    
    private List<string> Colors = new List<string>() {"#0095FF","#FF0000", "#00FF00",  "#FFFF00", "#FFA500", "#9000FF", "#FF0FC6", "#FFFFFF", "#4D4D4D" };
    private List<string> ColorNames = new List<string>() { "Blue", "Red", "Green", "Yellow", "Orange", "Purple", "Pink", "White", "Black" };
    private int colorIndex = 0;
    
    
    public void ChangeColor()
    {
        if (colorIndex >= Colors.Count - 1)
        {
            colorIndex = 0;
        }
        else
        {
            colorIndex++;
        }

        if (colorIndex >= 0 && colorIndex < Colors.Count)
        {
            string selectedColorHex = Colors[colorIndex];
            Color color;

            if (ColorUtility.TryParseHtmlString(selectedColorHex, out color))
            {
                // Change sprite prefab colors
                if (scriptImg != null) scriptImg.color = color;

                Debug.Log($"Color changed to {ColorNames[colorIndex]} ({selectedColorHex})");
            }
            else
            {
                Debug.LogWarning("Invalid hex color string.");
            }
        }
        else
        {
            Debug.LogWarning("Color index out of range.");
        }
    }
}
