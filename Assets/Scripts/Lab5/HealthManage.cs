using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthManage : MonoBehaviour
{
    [SerializeField] private Image healthBar;
    [SerializeField] private float healthAmount = 100f;
    [SerializeField] private Camera camera;
    [SerializeField] private Transform target;

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(10);
        }

        if (Input.GetKeyDown(KeyCode.H))
        {
            Heal(5);
        }

        transform.position = camera.transform.position;
        transform.position = target.position;
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
