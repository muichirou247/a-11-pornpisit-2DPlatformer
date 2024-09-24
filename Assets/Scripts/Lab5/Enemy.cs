using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Enemy : Character
{
    private int damagehit;
    public int DamageHit
    {
        get
        {
            return damagehit;
        }
        set 
        {
            damagehit = value;
        }

    }

    private void Start()
    {
        Behavior();
    }
    public abstract void Behavior();
 
}
