using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Croccodile : Enemy, IShootable
{
     float attackRange;
     public float AttackRange { get { return attackRange; } set { attackRange = value; } }
     [SerializeField] private Player player;
     [field: SerializeField]
     GameObject bullet;
     public GameObject Bullet {  get { return bullet; } set {  bullet = value; } }
    
     [field: SerializeField]
     Transform bulletSpawnPoint;
     public Transform BulletSpawnPoint { get { return bulletSpawnPoint; } set { bulletSpawnPoint = value; } }
     public float ReloadTime {  get; set; }
     public float WaitTime {  get; set; }
     private int damageHit;
    


    public void Start()
    {
        Init(50);
        WaitTime = 0.0f;
        ReloadTime = 3.0f;
        damageHit = 10;
        attackRange = 6;
        player = GameObject.FindObjectOfType<Player>();
        Debug.Log($"Croccodile HP = {Health}");

        Behavior();
    }
        void FixedUpdate()
    {

        WaitTime += Time.fixedDeltaTime;
        Behavior();

        }
        public override void Behavior()
        {
        Vector2 direction = player.transform.position - transform.position;
        float distance = direction.magnitude;
        if(distance < attackRange)
        {
            Shoot();          
        }
        }

        public void Shoot()
        {
        if (WaitTime >= ReloadTime)
        {
            anim.SetTrigger("Shoot");
            GameObject obj = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);
            Rock rockObj = obj.GetComponent<Rock>();

            rockObj.Init(30, this);
           
            WaitTime = 0;
        }
        }

}
