using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Character : MonoBehaviour
{
  [SerializeField] private int health;
    public int Health 
    { get  
        { 
        return health;
        }

      set
        {
            health = value;
        }
    }

    public void Init(int newHealth)
    {
        Health = newHealth;
    }

    public Animator anim;

    public Rigidbody2D rb;

    public bool IsDead()
    {
        if (Health <= 0)
        {
            Destroy(this.gameObject);
            return true;

        }
        else return false;
    }

    public void takeDamage(int damage)
    {
        Health =-damage;
        Debug.Log($"takeDamage: {damage} ,hp: {Health}");
        IsDead();
    }

}
