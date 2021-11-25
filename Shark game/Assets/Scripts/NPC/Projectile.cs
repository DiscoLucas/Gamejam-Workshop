using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Projectile : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        
    }

    private void OnCollisionEnter(Collision other)
    {
        if (other.CompareTag("Player"))
        {
            Level.AddExp(-50);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
