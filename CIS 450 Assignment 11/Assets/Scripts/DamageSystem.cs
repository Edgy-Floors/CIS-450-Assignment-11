using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DamageSystem : MonoBehaviour
{
    public int baseDamage = 5;
    public HealthSystem h;

    private void Start()
    {
        h = GameObject.Find("HealthSystem").GetComponent<HealthSystem>();
    }

    public IEnumerator DealDamage()
    {
        yield return new WaitForSeconds(1.0f);
        h.ReduceHealth(baseDamage);
    }
}
