using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class Projectile : MonoBehaviour
{
public Level level;

    private void OnCollisionEnter(Collision coll)
    {
        if (coll.CompareTag("Player"))
        {
            level.AddExp(-50);
        }
    }

    
}
