using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shooter : MonoBehaviour
{
    [SerializeField] Transform shootingPoint;


    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }

    public void Shoot()
    {
        Proiettile newProiettile = ProiettilePool.Instance.GetProiettile();

        newProiettile.transform.position = shootingPoint.position;
        newProiettile.GetComponent<SpriteRenderer>().color = GetComponent<SpriteRenderer>().color;
        newProiettile.SetDirection(shootingPoint.position - transform.position);
    }
}
