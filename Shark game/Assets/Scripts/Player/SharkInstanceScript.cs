using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkInstanceScript : MonoBehaviour
{
    public GameObject shark;
    // Start is called before the first frame update
    void Update()
    {
        Destroy(this.shark, 2f);
    }


}
