using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class groundCheck : MonoBehaviour
{
    // vanlig bool som andvänds för att komunecera mellan andra koder och scripts 
    public int isgrounded = 1;
    public bool isPlayer;

    // gör någonting ifall triggern rör någonting 
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //ökar isgrounded med ett
        isgrounded++;
        //kollar ifall boolen isPlayer är på
        if (isPlayer == true)
        {
            //kollar ifall det är ground som faktiskt rör triggern
            if (collision.tag == "Ground")
            {
                //gör så att isgrounded = 1
                isgrounded = 1;
            }
        }
    }
    // gör någont ifall triggern inte rör någonting 
    private void OnTriggerExit2D(Collider2D collision)
    {
        //..gör tillsammans med den övre koden mer konsitant så man inte blir utelåst från att hoppa eller får mer en ett hopp
        isgrounded--;
        // gör så att isgrounded = false 
        if (isPlayer == true)
        {
            // kollar ifall playern har double jump eller inte
            if (powerup.playerState == 2)
            {
                // gör så att man får antaler jumps som poweruppen tilllåter (1 defult)
                isgrounded = powerup.airJumps;
            }
            // vad som händr om player inte har doublejump
            else
            {
                //gör så att isgrounded är 0
                isgrounded = 0;
            }
        }
    }
}
