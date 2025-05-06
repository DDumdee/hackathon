using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LelvelChanger : MonoBehaviour
{
    public TextMeshProUGUI levelText;
    public GameObject Button1;
    public GameObject ButtonLevel2;
    
    
    public GameObject Cage;
    public GameObject KeyInventory;
    public GameObject Key1;
    
    public Image image;
    [SerializeField] public Sprite[] scriptAnimationNextLevel;
    private int spriteIndex = 0;
    private int level = 1;

    private bool forwardFlip = true;

    public void LevelChange()
    {
        if (level == 1)
        {
            Level2();
            level++;
            levelText.text = "Level " + level;
        } 
        else if (level == 2)
        {
            Level3();
            level++;
            levelText.text = "Level " + level;
        } else if (level == 3)
        {
            End();
        }
    }
    private void Level2()
    {
        FlipTheScript();
        Button1.SetActive(false);
        ButtonLevel2.SetActive(true);
        forwardFlip = false;
        Debug.Log("Changed to: " + forwardFlip);
    }
    private void Level3()
    {
        FlipTheScript();
        Button1.SetActive(true);
        ButtonLevel2.SetActive(false);
        
        Cage.SetActive(true);
        Key1.SetActive(true);
        forwardFlip = true;
        Debug.Log("Changed to: " + forwardFlip);
    }

    private void End()
    {
        SceneManager.LoadScene("End");
    }
    
    private void FlipTheScript()
    {
        for (int i = 0; i < scriptAnimationNextLevel.Length; i++)
        {
            AnimationChanger();
            StartCoroutine(wait());
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
