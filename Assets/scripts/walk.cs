using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class walk : MonoBehaviour
{
    // script for controlled movement
    
    // variabler för mer flexibilitet
    public float moveSpeed = 6;
    public float jumpSpeed = 12;
    // nämner en kallad script
    public groundCheck check;
    // nämner en kallad rigidbody
    private Rigidbody2D rbody;

    void Start()
    {
        // kallar på sin egen rigidbody
        rbody = GetComponent<Rigidbody2D>();
    }
    
    void Update()
    {
        // gör så att karaktärens movement är lika med spelets horizontal keybind multiplicerat med speed multiplyern
        rbody.velocity = new Vector2(
            Input.GetAxisRaw("Horizontal") * moveSpeed, 
            rbody.velocity.y);

        // kollar ifall spelets jump knapp är nedtrykt
        if (Input.GetButtonDown("Jump"))
        {
            // kollar kollar ifall isgrounded (från den tidigare kallade scripten) är true
            if (check.isgrounded > 0)
            {
                // sätter vertikal hastighet likamed dens jumpspeed
                rbody.velocity = new Vector2(rbody.velocity.x, jumpSpeed);
                check.isgrounded -= 1;
            }
        }
    }
}
