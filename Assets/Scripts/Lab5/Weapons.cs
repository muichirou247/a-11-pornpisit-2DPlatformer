using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public abstract class Weapons : MonoBehaviour
{
    [SerializeField] private int damage;
        public int Damage
        {
        get { return damage; }
        set { damage = value; }
        }

        public IShootable shooter;

        protected string Owner;

    public void Start()
    {
        Move();
        
    }

    public abstract void OnHitWith(Character character);
    public abstract void Move();

    public void Init(int _damage, IShootable _owner)
    {
        Damage = _damage;
        shooter = _owner;
    }
       
    public int GetShootDirection()
    {
        float shootDir = shooter.BulletSpawnPoint.position.x - shooter.BulletSpawnPoint.parent.position.x;
        if (shootDir > 0)
        {
            return 1;
        }
        else return -1;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        OnHitWith(other.GetComponent<Character>());
        Destroy(this.gameObject);
        
    }

}
