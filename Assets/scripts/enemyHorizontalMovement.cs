using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyHorizontalMovement : MonoBehaviour
{
    // detta är en mer advanced script som inte behöver triggers för att vända sig utan känner av marken.
    // den är däremot inte lika flexibel.

    // variabel för hur snabbt saken ska röra sig
    public float speed = 2f;
    // variabel för att kunna byta håll på saken
    public bool left = true;
    // kollar ifall  
    public groundCheck check;
    //namnger sin egen rigidbody
    private Rigidbody2D rbody;

    // Use this for initialization
    void Start()
    {
        //kallar på sin egen rigidbody
        rbody = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //kollar ifall left är true ...
        if (left == true)
        {
            // lägger till speed variabelns kraft åt 
            rbody.MovePosition(rbody.position + (-(Vector2)transform.right * Time.deltaTime * speed));
            // rescalar spriten så den kollar vänster (vänder tillbaka den ifall den blivit omvänd av koden nedanför)
            transform.localScale = new Vector3(1, 1, 1);
        }
        // ... eller ifall den inte är det
        else
        {
            // lägger till speed variabelns kraft åt
            rbody.MovePosition(rbody.position + ((Vector2)transform.right * Time.deltaTime * speed));
            // rescalar spriten så den kollar
            transform.localScale = new Vector3(-1, 1, 1);
        }
        //kollar ifall isgroundet från den tidigare länkade koden är false
        if (check.isgrounded <= 0)
        {
            // togglar left boolen
            left = !left;
            //check.isgrounded = 0;
        }

    }
    //kollar ifall någonting rör dens trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
 
        
            // ifall den gör det togglar den left variabeln
            left = !left;
        
    }
}
