using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bonusGamePlayer : MonoBehaviour
{
    //basic variabler
    public float moveSpeed = 6;
    private Rigidbody2D rbody;

    // Update is called once per frame
    void Update()
    {
        Movement();
    }

    public void Movement ()
    {
        //när man trycker åt höger eller vänster så flytas spelaren beroende på moveSpeed variabeln oberoende av din framerate   
        if (Input.GetKey(KeyCode.D))
        {
            transform.Translate(moveSpeed * Time.deltaTime, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            transform.Translate(-moveSpeed * Time.deltaTime, 0, 0);
        }
    }

    //gör någonting när en sak går in i dens trigger
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //vad som händer om man rör ett poäng
        if(collision.tag == "bonusLvPoint")
        {
            //förstör poängen
            Destroy(collision.gameObject
);
            //addar score
            coin.score += 10;
        }
        //vad som händer om man rör en fiende
        if(collision.tag == "bonusLvEnemy")
        {
            // resettar spelarens score 
            coin.score = 0;
            // loadar main menu scenen
            SceneManager.LoadScene("elmerPlatformer1_mainMenu");
        }
    }
}
