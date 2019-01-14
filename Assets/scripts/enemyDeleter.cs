using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemyDeleter : MonoBehaviour {

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Enemy" || collision.tag == "bonusLvPoint" || collision.tag == "bonusLvEnemy")
        {
            Destroy(collision.gameObject);
        }
    }

}
