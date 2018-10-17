using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody2D))]
public class Player : MonoBehaviour
{

    public float movementSpeed = 10f;
    public float levelWidth = 2f;
    public bool isDead = false;

    Rigidbody2D rb;

    float movement = 0f;
    public float score;
    float movementx = 0f;
    Vector2 newx;

    private float Deep = 5f;


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        movement = Input.GetAxis("Horizontal") * movementSpeed;
        score = FellDown()+5;
        if (transform.position.x <= -levelWidth)
        {
            newx = transform.position;
            newx.x += levelWidth * 2;
            transform.position = newx;
        }

        if (transform.position.x >= levelWidth)
        {
            newx = transform.position;
            newx.x += -levelWidth * 2;
            transform.position = newx;
        }

    }

    void FixedUpdate()
    {
        Vector2 velocity = rb.velocity;
        velocity.x = movement;
        rb.velocity = velocity;
    }

    float FellDown()
    {
        float DownLimit = Camera.main.GetComponent<Transform>().position.y - Deep;
        if (transform.position.y <= DownLimit)
        {
            isDead = true;
        }
        return DownLimit;
    }

}
