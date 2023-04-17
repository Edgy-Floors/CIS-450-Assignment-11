/*
 *  EJ Flores
 *  DamageSystem.cs
 *  Assignment 11
 *  This is the damage system that my facade connects to. It handles dealing damage through a reference to the health system.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    public int baseDamage = 5;
    public HealthSystem h;

    public IEnumerator DealDamage()
    {
        while (true)
        {
            yield return new WaitForSeconds(1.0f);
            h.ReduceHealth(baseDamage);
        }
    }
}
