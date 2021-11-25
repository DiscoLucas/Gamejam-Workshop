using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MilBaseDestroy : MonoBehaviour
{
    //making a variable from the Objective script
    public Objective gameManager;

    // Start is called before the first frame update
    void Start()
    {
        //Setting the variable to find the Gamemanager object, and get components from the Objective script
        gameManager = GameObject.Find("Gamemanager").GetComponent<Objective>();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("EnemyBase"))
        {
            Destroy(other.gameObject);
            //Add 1 to the Bases variable
            gameManager.Bases += 1;
        }
    }
}
