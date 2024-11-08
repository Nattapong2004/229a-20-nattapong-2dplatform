using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    public int damageHit;
   public int DamageHit
    { 
        get
        {
            return damageHit;
        }

        set
        {
            damageHit = value;
        }
    
    }

    private void Start()
    {
        Behavior();
    }

    public abstract void Behavior();
    
}
