using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SharkInstanceScript : MonoBehaviour
{
    private GameObject shark;
    // Start is called before the first frame update
    void Start()
    {
        Destroy(this.shark, 2f);
    }


}
