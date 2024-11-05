using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapon
{
    public void Start()
    {
        Damage = 20;
        force = new Vector2 (GetShootDirection() * 100, 400);

        Move();

    }

    private Rigidbody2D rb2d;

    private Vector2 force;
    

    public override void Move()
    {
        //Debug.Log("Rock move with Rigidbody:force");
        rb2d.AddForce (force,ForceMode2D.Impulse);
    }

    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.takeDamage(this.Damage);
        }
    }
}
