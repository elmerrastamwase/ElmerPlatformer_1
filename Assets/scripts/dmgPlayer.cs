using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class dmgPlayer : MonoBehaviour
{

    // variabel för vilken level som ska loadas (lv1 deffult)
    public string levelLoad = "elmerPlatformer1_scene1";

    // kollar ifall någonting rör sakens trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //kollar ifall saken som rör triggern är taggad med 'Player'
        if (collision.tag == "Player")
        {
            // loadar scen beroende på 'levelLoad'
            SceneManager.LoadScene(levelLoad);
            // resettar spelarens score när en level loadas (dör ellar går in i nästa bana) 
            coin.score = 0;
            // playern förlorar sin powerup
            powerup.playerState = 1;
        }
    }
}
