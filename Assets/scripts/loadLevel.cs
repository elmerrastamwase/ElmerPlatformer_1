﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class loadLevel : MonoBehaviour
{
    // variabel för hur mycker scare man behöver för att triggera level loadern
    public int minScore;
    // variabel för vilken level som ska loadas (lv1 deffult)
    public string levelToLoad = "elmerPlatformer1_scene1";

    // kollar ifall någonting rör sakens trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {   
        // kollar ifall saken som kolliderar är taggad med "Player" och ifall man har minimum
        if (collision.tag == "Player" && coin.score >= minScore)
        {
            //spelar levelLoad voiden
            levelLoad();
            
        }
    }

    public void levelLoad()
    {
        // resettar spelarens score när en level loadas (dör ellar går in i nästa bana) 
        coin.score = 0;
        // loadar scen beroende på 'levelToLoad'
        SceneManager.LoadScene(levelToLoad);
        // playern förlorar sin powerup
        powerup.playerState = 1;
    }
}
