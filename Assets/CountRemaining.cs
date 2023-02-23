using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class CountRemaining : MonoBehaviour
{
    public Text counter;
    public GameObject you_win;
    public GameObject ball_to_stop_rotation;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (counter.text == "0")
        {
            Time.timeScale = 0;
            you_win.SetActive(true);
            ball_to_stop_rotation.SetActive(false);

            if (Input.GetKeyDown("r"))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
                Time.timeScale = 1;
            }
        }
    }
}
