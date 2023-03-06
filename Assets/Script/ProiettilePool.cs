using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProiettilePool : MonoBehaviour
{
    public static ProiettilePool Instance { get; private set; }

    [SerializeField] Proiettile proiettilePrefab;
    [SerializeField] int poolSize = 10;

    Stack<Proiettile> _pool;
    private void Awake()
    {
        _pool = new Stack<Proiettile>();
    }

    private void Start()
    {
        if (Instance == null)
        {
            Instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        for (int i = 0; i < poolSize; i++)
        {
            Proiettile newProiettile = Instantiate(proiettilePrefab);
            newProiettile.gameObject.SetActive(false);
            _pool.Push(newProiettile);
        }
    }

    public Proiettile GetProiettile()
    {
        Proiettile proiettile = _pool.Pop();
        proiettile.gameObject.SetActive(true);

        return proiettile;
    }

    public void ReturnProiettile(Proiettile proiettile)
    {
        _pool.Push(proiettile);
        proiettile.gameObject.SetActive(false);
    }

}
