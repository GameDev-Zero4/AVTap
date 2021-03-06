﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {
	public GameObject touch;
    public static GamePlayController instance;
    [SerializeField]
    private Text scoreText, endScoreText, bestScoreText;
    [SerializeField]
    private GameObject overpanel;
    [SerializeField]
    private static int bestscore;
    private AudioSource _nhac;
    void Awake()
    {
        _nhac = GetComponent<AudioSource>();
        _MakeInstance();

    }
   public void setState()
    {
        overpanel.SetActive(false);
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
        _nhac.Stop();
        Time.timeScale = 0;

		touch.SetActive (false);
        overpanel.SetActive(true);

		//overpanel.gameObject.GetComponent<MeshRenderer> ().sortingOrder=4;
         endScoreText.text = "" + score;
         if (score > bestscore)
        {
            bestscore = score;
        }
        bestScoreText.text = "" + bestscore;

    }
    public void RestartGameButton()
    {
		touch.SetActive (true);
        Application.LoadLevel("Play_Copy");
        Time.timeScale = 1;
		//overpanel.gameObject.GetComponent<MeshRenderer> ().sortingOrder=2;
        //Application.LoadLevel (Application.loadedLevel);
    }
}
