using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move_bird : MonoBehaviour
{
    
    public  Rigidbody2D Myrigidbody2D;
    public float Speed = 10f;
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (!logic_manager.instance.isGameStart)
        {
            return;
        }
        jump();
    }
    private void FixedUpdate()
    {
        if (!logic_manager.instance.isGameStart)
        {
            return;
        }
    }
    void jump()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Myrigidbody2D.velocity = Vector2.up * Speed ;
        }

    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Mid"))
        {
            logic_manager.instance.addScore(1);

        }

        if (collision.CompareTag("Pipe"))
        {
            logic_manager.instance.ShowGameOver();
          
        }
        

    }
}
