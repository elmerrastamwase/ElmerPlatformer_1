using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class coin : MonoBehaviour
{
    //static score är samma i alla scripts. detta gör att vi kan ha en score counter lättare.
    public static int score;
    //variabel för ur mycket ett visst mynt är värt
    public int points = 1;
    //variabel för rotations hastighet på olika sorters mynt
    public int rotation;

    // Update is called once per frame
    void Update()
    {
        //kod för fancy spin runt y axeln
        transform.Rotate(0, rotation * Time.deltaTime,0 );
    }

    //kollar ifall någonting rör triggern
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //kollar ifall saken som rör triggern är taggad med player
        if (collision.tag == "Player")
        {
            // förstör myntet och addar myntets värde (points) till score variabeln
            Destroy(gameObject);
            // lägger på myntets värde till score
            coin.score += points;
        }
    }
}
