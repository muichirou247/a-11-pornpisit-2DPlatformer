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



    protected string Owner;

    public void Start()
    {
        Move();
        
    }

    public abstract void OnHitWith(Character character);
    
    public abstract void Move();
     
    public int GetShootDirection()
    {
        return 1;
    }

}
