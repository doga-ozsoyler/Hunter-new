﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class score : MonoBehaviour
{
    public static int duckNum = 0;
    Text duckScore;
    
    void Start()
    {
        duckScore = GetComponent<Text>();
    }

    void Update()
    {
        duckScore.text = "Score: " + duckNum;
    }
}
