using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fallingReset : MonoBehaviour {

    //hur högt sakerna ramlar ifrån
    public float fallHight = 40;

    //gör någoting när någonting rör triggern
    public void OnTriggerEnter2D(Collider2D collision)
    {
        // kollar om saken som rör triggern är taggad med 'Enemy'

        if(collision.tag == "Enemy" || collision.tag == "bonusLvPoint" || collision.tag =="bonusLvEnemy")
        {
            // gör så att sakens horizontalala position är random men fortfarande över 
            collision.transform.position = new Vector3 (Random.Range(transform.position.x -8,transform.position.x +8), fallHight, 0);
        }
    }


}
