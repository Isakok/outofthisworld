using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovementScript : MonoBehaviour
{

    public float moveSpeed = 10.0f;
    public float movement = 0f;
    private Vector3 velocity = Vector3.zero;
    public Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2d = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        //walk
        movement = Input.GetAxis("Horizontal");
        Vector3 targetVelocity = new Vector2(movement * moveSpeed, rigidbody2d.velocity.y);
        rigidbody2d.velocity = Vector3.SmoothDamp(rigidbody2d.velocity, targetVelocity, ref velocity, 0.05f);
        //jump
    }
}
