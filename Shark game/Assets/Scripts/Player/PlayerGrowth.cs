using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class PlayerGrowth : MonoBehaviour
{
    // Start is called before the first frame update
    public Level level;
    void Start()
    {
        level = new Level(1, OnLevelUp);

    }

    public void OnLevelUp()
    {
        print("I leveled up!");
    }

    // Update is called once per frame
    void Update()
    {
      collideCheck = myGameObject.GetComponent<CollideCheck>();    
 
                 if (collideCheck .IsCollided() && whatever other conditions you want)
                 {
                     collideCheck .ResetCollision();
                 }
    }