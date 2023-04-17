/*
 *  EJ Flores
 *  HealthSystem.cs
 *  Assignment 11
 *  This is the health system that my facade connects to. It handles healing, reducing health, and returning the value of the current health.
 */

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
