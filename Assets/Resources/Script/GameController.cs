﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class GameController : MonoBehaviour {

    public bool gameover = false;
    public GameObject pl;
    public GameObject gameoverTaxt;
    public GameObject scoreTaxt;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (pl.GetComponent<Player>().isDead)
        {
            DoodleDied();
        }
	}

    public void DoodleDied()
    {
        ShowGanmeOver();
        ShowScore();
    }

    private void ShowGanmeOver()
    {
        gameover = true;
        gameoverTaxt.SetActive(true);
    }

    private void ShowScore()
    {
        scoreTaxt.GetComponent<Text>().text = "SCORE:" + pl.GetComponent<Player>().score.ToString("0");
        scoreTaxt.SetActive(true);
    }


}
