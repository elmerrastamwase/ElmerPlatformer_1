using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class invisibleWall : MonoBehaviour {

	// Use this for initialization
	void Start ()
    {
        //kod för att stänga av sprite renderern när spelet startar (bli osynlig)
        GetComponent<SpriteRenderer>().enabled = false;
	}
}
