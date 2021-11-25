using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerGrowth : MonoBehaviour
{
    public Level level;


    // Start is called before the first frame update
    void Start()
    {
        level = new Level(1, OnLevelUp);

    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            level.AddExp(100);
        }
    }


    public void OnLevelUp()
    {
        print("The sharknado grew in size!");
        this.transform.localScale = this.transform.localScale + new Vector3(1f, 1f, 1f);

    }



    // Update is called once per frame
    void Update()
    {
      
       
    }
}
