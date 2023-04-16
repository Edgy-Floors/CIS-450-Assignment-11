using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthSystem : MonoBehaviour
{
    public int maxHealth = 100;
    private int currentHealth;

    private void Start()
    {
        currentHealth = maxHealth;
    }

    public void Heal()
    {
        currentHealth += 10;
    }

    public int GetHealth()
    {
        return currentHealth;
    }

    public void ReduceHealth(int healthToReduce)
    {
        currentHealth -= healthToReduce;
    }
}
