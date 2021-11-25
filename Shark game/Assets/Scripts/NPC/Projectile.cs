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

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            this.transform.localScale = this.transform.localScale - new Vector3(-0.5f, -0.5f, -0.5f); 

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
