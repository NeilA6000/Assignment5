using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 5f;
    public float jumpSpeed = 8f;
    private float direction = 0f;
    private Rigidbody2D player;
    public bool isGrounded;

    
    void Start()
    {
        player = GetComponent<Rigidbody2D>();
    }

    
    void Update()
    {
        direction = Input.GetAxis("Horizontal");

        
        player.velocity = new Vector2(direction * speed, player.velocity.y);

        
        if (Input.GetButtonDown("Jump") && isGrounded)
        {
            player.velocity = new Vector2(player.velocity.x, jumpSpeed);
            isGrounded = false;
        }
    }

    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Floor"))
        {
            isGrounded = true;
        }
    }
}
