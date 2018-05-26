﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {

    public static GamePlayController instance;
    [SerializeField]
    private Text scoreText, endScoreText, bestScoreText;
    [SerializeField]
    private GameObject overpanel;
    [SerializeField]
    private static int bestscore;   

    void Awake()
    {
        
        _MakeInstance();
    }

    void _MakeInstance()
    {
        if (instance == null)
        {
            instance = this;
        }
    }

    public void _SetScore(int score)
    {
        scoreText.text = "" + score;
    }
    public void PlayDied(int score)
    {
        Time.timeScale = 0;
        overpanel.SetActive(true);
        
         endScoreText.text = "" + score;
         if (score > bestscore)
        {
            bestscore = score;
        }
        bestScoreText.text = "" + bestscore;

    }
    public void RestartGameButton()
    {
        Application.LoadLevel("Play_Copy");
        Time.timeScale = 1;
        //Application.LoadLevel (Application.loadedLevel);
    }
}