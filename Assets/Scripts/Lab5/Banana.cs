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
        Damage = 30;
        speed = 4f;
        Move();
               
    } 
    public override void Move()
    {
        Debug.Log("Banana เคลื่อนที่ด้วย Transform ด้วยความเร็วคงที่");
    }

    public override void OnHitWith(Character character)
    {
        
    }
}
