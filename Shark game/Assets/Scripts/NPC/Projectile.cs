using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Projectile : MonoBehaviour
{
    public Level level;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (Collision.collider.CompareTag("Player"))
        {
            level.AddExp(-50);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
