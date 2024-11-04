using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : Character,IShootable
{
    [field: SerializeField]
    GameObject bullet;
    public GameObject Bullet { get { return bullet; } set { bullet = value; } }

    [field: SerializeField]
    Transform bulletSpawnPoint;
    public Transform BulletSpawnPoint { get { return bulletSpawnPoint; } set { bulletSpawnPoint = value; } }
    public float ReloadTime { get; set; }
    public float WaitTime { get; set; }
  
    private void Start()

    {
        Init(100);
        Debug.Log($"Player HP = {Health}");
        WaitTime = 0.0f;
        ReloadTime = 1.0f;
    }

        void Update()
        {

        Shoot();
        
        }
    public void Shoot()
    {
        if (Input.GetButtonDown("Fire1") && WaitTime >= ReloadTime)
        {
            GameObject obj = Instantiate(bullet, bulletSpawnPoint.position, Quaternion.identity);   
        }
    }
    public void OnHitWith()
    {
        
    }

}
