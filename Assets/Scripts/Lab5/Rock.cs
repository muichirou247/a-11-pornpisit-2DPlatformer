using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rock : Weapons
{
    private Rigidbody rb2d;
    private Vector2 force;

    public void Start()
    {
        Damage = 40;
        Move();
    }
    public override void Move()
    {
        Debug.Log("Rock เคลื่อนที่ด้วย RigidBody: force");
    }

    public override void OnHitWith(Character character)
    {

    }
}
