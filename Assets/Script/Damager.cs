using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Damager : MonoBehaviour
{
    public int DamageValue;

    public UnityEvent onHit;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        Damageable damageable= collision.GetComponent<Damageable>();

        if (damageable)
        {
            damageable.Damage(DamageValue);

            onHit?.Invoke();
        }

    }
}
