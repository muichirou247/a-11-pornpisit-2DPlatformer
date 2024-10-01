using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodile : Enemy
{
    private float attackRange;
    private Player player;
    private float waitTime;
    private float reloadTime;
    private int damageHit;
    private Animator animator;


    public void Start()
    {
        Init(50);
        waitTime = 0.0f;
        reloadTime = 5.0f;
        damageHit = 30;
        attackRange = 6;
        Debug.Log($"Croccodile HP = {Health}");

        Behavior();
    }
    public override void Behavior()
    {
        Vector2 distance = player.transform.position - transform.position;
        if(distance.magnitude <= attackRange)
        {
            Shoot();
        }
    }
    void Shoot()
    {
        if (waitTime >= reloadTime)
        {
            animator;
        }
    }
   
}
