using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnPointRandomizer : MonoBehaviour {

	// Update is called once per frame
	void Update () 
    {
        //väljer en random position över spelaren
        transform.position = new Vector3(Random.Range(-6, 6), 7, 0);
	}
}
