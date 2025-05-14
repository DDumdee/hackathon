using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class LelvelChanger : MonoBehaviour
{
    //public TextMeshProUGUI levelText;
    
    public Image image;
    [SerializeField] public Sprite[] scriptAnimationNextLevel;
    public static LelvelChanger Instance;
    private int spriteIndex = 0;
    private int level = 1;

    private bool forwardFlip = true;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }
        // end of new code

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }
    
    
    public void LevelChange()
    {
        image = GameObject.FindGameObjectWithTag("Script").GetComponent<Image>();
        if (level == 1)
        {
            Level2();
            level++;
            //levelText.text = "Level " + level;
        } 
        else if (level == 2)
        {
            Level3();
            level++;
            //levelText.text = "Level " + level;
        } else if (level == 3)
        {
            Level4();
            level++;
        }
        else if (level == 4)
        {
            Level5();
            level++;
        }
        else if (level == 5)
        {
            End();
        }
    }
    private void Level2()
    {
        FlipTheScript();
        forwardFlip = false;
        Debug.Log("Changed to: " + forwardFlip);
        SceneManager.LoadScene("Level2");
    }
    private void Level3()
    {
        FlipTheScript();
        forwardFlip = true;
        Debug.Log("Changed to: " + forwardFlip);
        SceneManager.LoadScene("Level3");
    }

    private void Level4()
    {
        FlipTheScript();
        forwardFlip = true;
        Debug.Log("Changed to: " + forwardFlip);
        SceneManager.LoadScene("Level4");
    }
    
    private void Level5()
    {
        FlipTheScript();
        forwardFlip = true;
        Debug.Log("Changed to: " + forwardFlip);
        SceneManager.LoadScene("Level5");
    }

    private void End()
    {
        SceneManager.LoadScene("End");
        level = 1;
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
