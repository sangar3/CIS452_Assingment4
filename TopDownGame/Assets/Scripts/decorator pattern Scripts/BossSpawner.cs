﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public  class BossSpawner: MonoBehaviour
{
    public int numbereneimes = 4;
    public GameObject boss;

    


    public void SpawnBoss()
    {
        Debug.Log("Boss spawned");
        boss.SetActive(true);
        if(numbereneimes==1)
        {
            Debug.Log("VICTORY!");
        }
    }
}