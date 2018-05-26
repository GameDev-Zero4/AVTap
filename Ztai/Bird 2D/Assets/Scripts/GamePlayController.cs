using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GamePlayController : MonoBehaviour {

    public static GamePlayController instance;
    [SerializeField]
    private Text scoreText;
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

}
