using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlocksProp : MonoBehaviour
{
    public Sprite spr1;
    public Text text;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        string buff;
        int intbuff;
        if (col.gameObject.tag == "ball")
        {
            Destroy(GetComponent<Rigidbody2D>().gameObject);
            buff = text.text;
            intbuff = System.Int32.Parse(buff);
            intbuff--;
            text.text = intbuff.ToString();
        }

    }

    // Update is called once per frame
    void Update()
    {

    }
}
