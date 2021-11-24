using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollideCheck : MonoBehaviour 
 {
     private bool isCollided;
     
     public bool IsCollided
     {
         get {return isCollided; }
     }
     
     void OnTriggerEnter(Collider other) 
     {
         if (other.gameObject.tag == "Obstacle")
         {
             isCollided = true;
         }
     }
     
     public void ResetCollision()
     {
         isCollided = false;
     }
 }