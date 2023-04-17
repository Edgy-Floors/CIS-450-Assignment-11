/*
 *  EJ Flores
 *  GameFacade.cs
 *  Assignment 11
 *  This is the facade that connects to my systems. It enables the higher level functions of healing, getting current health, taking damage, pausing, unpausing, and getting pause state.
 */

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameFacade : MonoBehaviour
{
    public PauseSystem p;
    public HealthSystem h;
    public DamageSystem d;

    public void Heal()
    {
        h.Heal();
    }

    public int GetHealth()
    {
        return h.GetHealth();
    }

    public IEnumerator TakeDamage()
    {
        return d.DealDamage();
    }

    public void Pause()
    {
        p.LoadPauseMenu();
    }

    public void Unpause()
    {
        p.UnloadPauseMenu();
    }

    public bool GetPauseState()
    {
        return p.GetPauseState();
    }
}
