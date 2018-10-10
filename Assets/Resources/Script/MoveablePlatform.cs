using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveablePlatform : MonoBehaviour
{
    public float Step = 8f;
    public float SmoothSpeed = 4f;
    public float jumpForce = 10f;
    Vector2 currentVelocity;
    public float looptime = 2f;

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.relativeVelocity.y <= 0f)
        {
            Rigidbody2D rb = collision.collider.GetComponent<Rigidbody2D>();
            if (rb != null)
            {
                Vector2 velocity = rb.velocity;
                velocity.y = jumpForce;
                rb.velocity = velocity;
            }
        }
    }

    void Update()
    {
        if ((int)(Time.time/ looptime) % 2 != 0)
        {
            Move(Step);
        }
        else Move(-Step);

    }

    void Move(float key)
    {
        Vector2 newPos = new Vector2(transform.position.x, transform.position.y + key);
        transform.position = Vector2.SmoothDamp(transform.position, newPos, ref currentVelocity, SmoothSpeed);
    }

}
