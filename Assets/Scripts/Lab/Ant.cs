using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ant : Enemy
{ 
    public void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        damageHit = 20;

        Init(100);

        Debug.Log(Health);

    }

    [SerializeField]private Vector2 velocity;

    [SerializeField]private Transform[] movePoints;

    private void FixedUpdate()
    {
        Behavior();
    }

    public override void Behavior()
    {
        rb.MovePosition(rb.position + velocity * Time.fixedDeltaTime);

        if(rb.position.x <= movePoints[0].position.x && velocity.x < 0)
        {
            Flip();
        }

        else if (rb.position.x >= movePoints[1].position.x && velocity.x > 0)
        {
            Flip();
}

    }

    private void Flip()
    {
        velocity *= -1;

        Vector2 charScale = transform.localScale;
        charScale.x *= -1;
        transform.localScale = charScale;

    }

    

}
