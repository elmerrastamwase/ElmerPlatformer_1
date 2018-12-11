using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class slowFall : MonoBehaviour {

    public int fallSpeed = 10;
	// Update is called once per frame
	void Update ()
    {
        // gör så att föremåler långsamt ramlar neråt i takt med 'fallspeed' oavsätt drag
        transform.Translate(0,-fallSpeed * Time.deltaTime,0);
	}
}
