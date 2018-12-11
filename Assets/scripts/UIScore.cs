using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class UIScore : MonoBehaviour 
{
    //variabel för vilken text jag vill ändra på
    private TextMeshProUGUI text;

	void Start ()
    {
        // kallar på rätt komponent i TextMeshPro
        text = GetComponent<TextMeshProUGUI>();
	}	
	void Update ()
    {
        // score counter kod med extra nollor
        text.text = string.Format("Score: {0:000000}", coin.score);
	}
}
