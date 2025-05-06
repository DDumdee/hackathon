using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class LelvelChanger : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    public GameObject Button1;
    public GameObject ButtonLevel2;
    
    public Image image;
    [SerializeField] public Sprite[] scriptAnimationNextLevel;
    private int spriteIndex = 0;
    private int level = 1;

    private bool forwardFlip = true;

    public void LevelChange()
    {
        for (int i = 0; i < scriptAnimationNextLevel.Length; i++)
        {
            AnimationChanger();
            StartCoroutine(wait());
        }

        if (level == 1)
        {
            Button1.SetActive(false);
            ButtonLevel2.SetActive(true);
            level++;
            levelText.text = "Level " + level;
            forwardFlip = false;
            Debug.Log("Changed to: " + forwardFlip);
        }
    }


    private void AnimationChanger()
    {
        //Debug.Log("animArr-1: " + (scriptAnimationNextLevel.Length-1) + "   animArr: " +scriptAnimationNextLevel.Length);
        Debug.Log(spriteIndex);
        image.sprite = scriptAnimationNextLevel[spriteIndex];
        Debug.Log("SpriteChanged: " + spriteIndex);
        Debug.Log(forwardFlip);
        if (forwardFlip)
        {
            if (spriteIndex == scriptAnimationNextLevel.Length-1)
            {
                Debug.Log("CoroutineStopped");
                //spriteIndex = 0;
                //StopCoroutine(wait());
            }
            else
            {
                spriteIndex++;
            }
        }
        else
        {
            if (spriteIndex == 0)
            {
                Debug.Log("CoroutineStopped");
                //  spriteIndex = scriptAnimationNextLevel.Length - 1;
                //StopCoroutine(wait());
            }
            else
            {
                spriteIndex--;
            }
        }
        
    }
    IEnumerator wait()
    {
        yield return new WaitForSeconds(0.5f);
    }
}
