using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public abstract class Character : MonoBehaviour
{
    [SerializeField] private int health;
    [SerializeField] private Image healthBar;

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }

    public Animator anim;
    public Rigidbody2D rb;

    public bool IsDead()
    {
        if (health <= 0)
        {
            Destroy(this.gameObject);
            return true;

            
        }
        else return false;
    }

    public void TakeDamage(int damage)
    {
        Health -= damage;       
        healthBar.fillAmount = Health / 100f;
        Debug.Log($"Player take damage {damage} Player Remaining");
        IsDead();
    }
    public void Init(int newHealth)
    {
        Health = newHealth;
    }
  
           
 

}

