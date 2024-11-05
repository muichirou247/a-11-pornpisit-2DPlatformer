using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapons
{
    private Rigidbody rb2d;
    private Vector2 force;

    public void Start()
    {
        Init(30, shooter);
        
        force = new Vector2 (GetShootDirection() * 80,  400);
        Move();
    }
    public override void Move()
    {
        rb2d.AddForce (force, ForceMode.Impulse);
    }

    public override void OnHitWith(Character character)
    {
        if (character is Player)
        {
            character.TakeDamage(this.Damage);
            Debug.Log("---------30");
        }

    }
}
