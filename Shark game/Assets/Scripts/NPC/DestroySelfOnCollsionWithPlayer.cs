using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfOnCollsionWithPlayer : MonoBehaviour
{
   private void OnTriggerEnter(Collider col) 
   {
       Destroy(col.gameObject);
   }
}
