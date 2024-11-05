using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManage : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] private float healthAmount = 100f;
 

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Y))
        {
            TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(5);
        }

        
    }

    public void TakeDamage(float damage)
    {
        healthAmount -= damage;
        healthBar.fillAmount = healthAmount / 100f;
    }

    public void Heal(float healing)
    {
        healthAmount += healing;
        healthAmount = Mathf.Clamp(healthAmount, 0, 100);

        healthBar.fillAmount = healthAmount / 100f;
    }  
    

}
