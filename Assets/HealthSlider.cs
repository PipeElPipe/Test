using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSlider : MonoBehaviour
{
    [SerializeField] Stats stats;
    [SerializeField] Image healthBar;

    private void Update()
    {
        healthBar.fillAmount = stats.health / stats.maxHealth;
    }
}
