using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleSpawner : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    private static int people;

    // Start is called before the first frame update
    void Start()
    {
        people = 0;
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    void Update() 
    {
        people = FindObjectsOfType<PeopleMovement>().GetLength(0);

        // Stopper spawn hvis der er X antal spawnet eller flere 
        if(people >= 1000) 
        {
            CancelInvoke("SpawnObject");
        }
         else if (people < 999) 
        {
            InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
        }
    }

    public void SpawnObject()
    {   
        Instantiate(spawnee, transform.position, transform.rotation);
        ++people;
        //Hvis stop spawning er klikket på i Inspectoren, inden Run, så spawner den kun 1
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
