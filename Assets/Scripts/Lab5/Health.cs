using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour
{
    public float MaxHealth = 100;
    float health = 0;

    private void Start()
    {
        health = MaxHealth;
    }

    public float GetHealthPercent()
    {
        return health/MaxHealth;
    }

    private void TakeDamage(float amount)
    {
        health -= amount;
        if (health < 0)
            health = 0;
    }
}