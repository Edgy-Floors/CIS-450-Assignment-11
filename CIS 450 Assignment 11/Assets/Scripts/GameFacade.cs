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

    public void TakeDamage()
    {
        d.DealDamage();
    }

    public void Pause()
    {
        p.LoadPauseMenu();
    }

    public void Unpause()
    {
        p.UnloadPauseMenu();
    }
}
