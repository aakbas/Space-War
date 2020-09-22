using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] float healt = 100;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        DamageDealer damageDealer = collision.gameObject.GetComponent<DamageDealer>();
        ProcessHit(damageDealer);
        Destroy(collision.gameObject);
    }

    private void ProcessHit(DamageDealer damageDealer)
    {
        healt -= damageDealer.GetDamage();
        
        if (healt <= 0)
        {
            Destroy(gameObject);
        }
    }
}

    
        


