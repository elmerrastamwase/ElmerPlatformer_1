using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class powerup : MonoBehaviour
{

    //en static int för att länka och att player alltid ska ha samma powerup i alla scripts
    public static int playerState = 1;
    public int powValue;
    public static int airJumps = 1;


    // kollar ifall någonting rör sakens trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //kollar ifall saken som rör triggern är taggad med 'Player'
        if (collision.tag == "Player")
        {
            // sätter spelarens state till poweruppens (powValue)
            playerState = powValue;
            // förstör poweruppen
            Destroy(gameObject);
        }

    }
}
