using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sharkexplosions : MonoBehaviour
{
   public GameObject explosion; // drag your explosion prefab here
 
 void OnCollisionEnter(){
     GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
     
     Destroy(expl, 2); // delete the explosion after 3 seconds
}
}