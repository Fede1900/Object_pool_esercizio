using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Damageable : MonoBehaviour
{
    [SerializeField] int maxHealth;
    int health;

    [SerializeField] bool alive => health > 0;


    // Start is called before the first frame update
    void Start()
    {
        health = maxHealth;
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void Damage(int amount)
    {
        health -= amount;

        Debug.LogFormat("ho ricevuto {0} danni ", amount);

        if (!alive)
        {
            Destroy(gameObject);
        }
    }
}
