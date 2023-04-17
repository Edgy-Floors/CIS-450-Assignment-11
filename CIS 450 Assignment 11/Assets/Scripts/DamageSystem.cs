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
