using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using System;

public class BallScript : MonoBehaviour
{
    public Rigidbody2D rig;
    public float power_ball;
    public GameObject you_lose;
    Vector2 normal_velocity;
    double vector_module; // starting velocity module
    double current_vector_module; // current velocity module
    double division;

    void Start()
    {
        //rig.AddForce(new Vector3(0.5f, 1.2f, 0f) * Time.deltaTime * power_ball);
        rig.velocity = new Vector2(2.5f,6);

        normal_velocity = rig.velocity;
        vector_module = Math.Sqrt(rig.velocity.x * rig.velocity.x + rig.velocity.y * rig.velocity.y);
        //print("start" + vector_module);
    }

    void FixedUpdate()
    {
        current_vector_module = Math.Sqrt(rig.velocity.x * rig.velocity.x + rig.velocity.y * rig.velocity.y);
        //print("curr" + current_vector_module);
        if (current_vector_module != vector_module)
        {
            division = vector_module / current_vector_module;
            rig.velocity = new Vector2(rig.velocity.x * (float)division, rig.velocity.y * (float)division);
        }
    }

        void Update()
    {
        Quaternion rotation_b = Quaternion.AngleAxis(8, new Vector3(0, 0, -1));
        transform.rotation *= rotation_b;

        if (gameObject.transform.position.y <= -5.5f)
        {
            Time.timeScale = 0;
           
            you_lose.SetActive(true);
            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale = 1;
                you_lose.SetActive(false);
            }           
        }
        if (Input.GetKeyDown("r"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            Time.timeScale = 1;
        }
    }
}
