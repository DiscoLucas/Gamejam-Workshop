using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkBullet : MonoBehaviour
{
 //Function will be called when this object hits an object with a collider
     void OnCollisionEnter(Collision collision)
    {   
         
          
        //Destroy this gameobject
        Destroy(gameObject);
 }    
  
}
