using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class followEntity : MonoBehaviour {

    public Transform targetPosition;
    public int entitySpeed = 2;

	// Update is called once per frame
	void Update ()
    {
        if (targetPosition.position.x >= transform.position.x)
        {
            transform.Translate(entitySpeed * Time.deltaTime, 0, 0);
        }
        if (targetPosition.position.x <= transform.position.x)
        {
            transform.Translate(-entitySpeed * Time.deltaTime, 0, 0);
        }
    }
}
