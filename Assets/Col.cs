using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Col : MonoBehaviour
{
    public Sprite spr1;
    public Sprite spr2;
    public Text text;

    private SpriteRenderer spriteRenderer;

    void Start()
    {
        spriteRenderer = GetComponent<SpriteRenderer>(); // we are accessing the SpriteRenderer that is attached to the Gameobject        
    }

    private void OnCollisionEnter2D(Collision2D col)
    {
        string buff1;
        int intbuff1;
        if (spriteRenderer.sprite == spr1)
        {
            spriteRenderer.sprite = spr2;
        }
        else
        {
            Destroy(GetComponent<Rigidbody2D>().gameObject);
            buff1 = text.text;
            intbuff1 = System.Int32.Parse(buff1);
            intbuff1--;
            text.text = intbuff1.ToString();
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
