using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class itemSpawner : MonoBehaviour {

    //public Transforms för att länka filken spanpoint och item som ska använas
    public Transform spawnPoint;
    public Transform Enemy;
    //public floats för att kunna ändra timern i unity
    public float minTimer = 0.3f;
    public float maxTimer = 1;
    //variabler för timer setup
    float spawnTimer;
    float spawnTimerGoal = 1;

    // Update is called once per frame
    void Update ()
    {
        //timern räknar upp varje sekund
        spawnTimer += 1 * Time.deltaTime;

        //när timern har nåt sit mål blir den resettad och får ett nytt
        if (spawnTimer >= spawnTimerGoal)
        {
            spawnTimer = 0;

            //det spawnars också ett item
            spawnTimerGoal = Random.Range(minTimer, maxTimer);
            for (int i = 0; i < 1; i++)
            {
                Instantiate(Enemy, spawnPoint.position, Quaternion.identity);
            }
        }
    }
}
