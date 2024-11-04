using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    public Health Health;
    public Image HealthBarGFX;

    private void Update()
    {
        float percent = Health.GetHealthPercent();
        HealthBarGFX.fillAmount = percent;
    }
}
