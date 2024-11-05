using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Banana : Weapon
{
    public void Start()
    {
        Damage = 30;
        speed = 4.0f * GetShootDirection();
    }

    private void FixedUpdate()
    {
        Move();
    }

    [SerializeField]private float speed;

    public override void Move()
    {
        //s = vt
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;

        //Debug.Log("Banana moves with constant speed using Transform");
    }

    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.takeDamage(this.Damage);
        }
    }
}
