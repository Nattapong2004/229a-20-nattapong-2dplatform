using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthBar : MonoBehaviour
{
    [SerializeField] Slider healthslider;

    public void SetMaxHealth(int health)
    {
        healthslider.maxValue = health;

        healthslider.value = health;

        Debug.Log($"Health slider: {healthslider.value} / {healthslider.maxValue}");

    }

    public void UpdateHealthBar(int health)
    {
        healthslider.value = health;
    }
}
