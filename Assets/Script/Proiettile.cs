using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Proiettile : MonoBehaviour
{
    [SerializeField] Rigidbody2D body;
    public float flySpeed = 20;
    public float liveTime = 3f;
    [SerializeField]float _liveTime;

    Vector3 direction;

    
    // Start is called before the first frame update
    private void OnEnable()
    {
        _liveTime = liveTime;
    }
    
        


    

    // Update is called once per frame
    void Update()
    {
        _liveTime -= Time.deltaTime;
        if (_liveTime <= 0)
        {
            RichiamaProiettile();
        }
        else
        {
            transform.position += direction.normalized * flySpeed * Time.deltaTime;
        }
        
    }

    public void RichiamaProiettile()
    {
        ProiettilePool.Instance.ReturnProiettile(this);
    }

    public void SetDirection(Vector3 vector)
    {
        direction = vector;
    }
}




