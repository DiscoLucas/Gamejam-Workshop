using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerGrowth : MonoBehaviour
{
    public Level level;
    //making a variable from the Objective script
    public Objective gameManager;

    // Start is called before the first frame update
    void Start()
    {
        level = new Level(1, OnLevelUp);
        //Setting the variable to find the Gamemanager object, and get components from the Objective script
        gameManager = GameObject.Find("Gamemanager").GetComponent<Objective>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Enemy"))
        {
            Destroy(other.gameObject);
            level.AddExp(100);
            //Add 1 to the Bases variable
            gameManager.Bases += 1;
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
