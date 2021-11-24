using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exlposion : MonoBehaviour
{
   public GameObject explosion; // drag your explosion prefab here
 
 void OnCollisionEnter(){
     GameObject expl = Instantiate(explosion, transform.position, Quaternion.identity) as GameObject;
     Destroy(gameObject); // destroy the grenade
     Destroy(expl, 2); // delete the explosion after 3 seconds
}
}