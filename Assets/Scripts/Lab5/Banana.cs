using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.TextCore.Text;

public class Banana : Weapons
{
    [SerializeField] private float speed;

    public void Start()
    {
        Damage = 20;
        speed = 2.0f * GetShootDirection();
        
               
    }

    void Update()
    {
        Move();
    }


    public override void Move()
    {   
        float newX = transform.position.x + speed * Time.fixedDeltaTime;
        float newY = transform.position.y;
        Vector2 newPosition = new Vector2(newX, newY);
        transform.position = newPosition;
    }

    public override void OnHitWith(Character character)
    {
        if (character is Enemy)
        {
            character.TakeDamage(this.Damage);
            Debug.Log("---------20");
        }
    }
}
