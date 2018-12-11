using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wormMovement : MonoBehaviour {
    // denna script är för en mer simpel fiende som andvänder osynliga triggers för att vända sig

    // variabel för hur snabbt saken ska röra sig 
    public float speed = 2f;
    // variabel för att kunna byta håll på saken
    public bool left = true;
    // nämner en rigidbody till rbody
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        // kallar på en specefik Rigidbody (sin egen)
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame (som vanliga update men för fysik baserade saker)
    void FixedUpdate()
    {
        //kollar om den ser år vänster (ifall left = true)
        if (left == true)
        {
            //simpel kod för att gå vänster genom att lägga till speed variabelns kraft åt vänster
            rbody.velocity= -(Vector2)transform.right * speed;
            // rescalar spriten så den kollar vänster (vänder tillbaka den ifall den blivit omvänd av koden nedanför)
            transform.localScale = new Vector3(1, 1, 1);
        }
        else
        {
            //simpel kod för att gå vänster genom att lägga till speed variabelns kraft åt höger
            rbody.velocity = (Vector2)transform.right * speed;
            // rescalar spriten så den kollar höger
            transform.localScale = new Vector3(-1, 1, 1);
        }
    }
    // kollar om någonting kolliderar med den
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //kollar ifall saken som rör den är taggad med "InvisibleWall"
        if (collision.tag == "InvisibleWall")
        {
            // toggelar bool variabeln 'left' (som styr ifall saken är vänd höger eller vänster)
            left = !left;
        }
    }
}
