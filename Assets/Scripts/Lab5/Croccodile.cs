using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodile : Enemy
{
    [SerializeField] private float attackRange;
    [SerializeField] private Player player;
    [SerializeField] private GameObject bullet;
    [SerializeField] private Transform bulletSpawnPoint;
    [SerializeField] private float bulletTimer;
    [SerializeField] private float waitTime;
    private int damageHit;
    


    public void Start()
    {
        Init(50);
        waitTime = 0.0f;
        bulletTimer = 8.0f;
        damageHit = 30;
        attackRange = 6;
        player = GameObject.FindObjectOfType<Player>();
        Debug.Log($"Croccodile HP = {Health}");

        Behavior();
    }
        private void Update()
        {
        bulletTimer -= Time.deltaTime;
        if (bulletTimer < 0)
        {
            bulletTimer = waitTime;
        }

        waitTime += Time.fixedDeltaTime;
        Behavior();

        }
    public override void Behavior()
    {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;
        if(distance < attackRange)
        {
            Shoot();
            Debug.Log("Shoot");
        }
    }

    void Shoot()
    {
        if (waitTime >= bulletTimer)
        {
            anim.SetTrigger("Shoot");
            GameObject obj = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);

            waitTime = 0;
        }
    }

}
