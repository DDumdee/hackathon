using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FindLevelChanger : MonoBehaviour
{
    private GameObject levelChanger;

    private void Start()
    {
        levelChanger = GameObject.FindGameObjectWithTag("LevelChanger");
    }

    public void LevelChangerFind()
    {
        levelChanger.GetComponent<LelvelChanger>().LevelChange();
    }
}
