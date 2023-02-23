using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour
{
    Rigidbody2D rg;
    public float Speed_Player;
    public float V_Speed_Player;

    void Start()
    {
        rg = GetComponent<Rigidbody2D>();
    }

    void FixedUpdate()
    {
        Vector3 final_vector = new Vector3(0, 0, 0);
                

        if (Input.GetAxis("Horizontal") > 0)
        {
            if (rg.position.x > 4f)
                final_vector += new Vector3(0, 0, 0);
            else
                final_vector += new Vector3(Speed_Player, 0, 0);
        }
        if (Input.GetAxis("Horizontal") < 0)
        {
            if (rg.position.x < -4.1f)
                final_vector += new Vector3(0, 0, 0);
            else
                final_vector += new Vector3(-Speed_Player, 0, 0);
        }

        if (Input.GetAxis("Vertical") > 0)
        {
            if (rg.position.y > -3)
                final_vector += new Vector3(0, 0, 0);
            else
                final_vector += new Vector3(0, V_Speed_Player, 0);
        }
        if (Input.GetAxis("Vertical") < 0)
        {
            if (rg.position.y < -4.5)
                final_vector += new Vector3(0, 0, 0);
            else
                final_vector += new Vector3(0, -V_Speed_Player, 0);
        }

        rg.velocity = final_vector;
    }
}
