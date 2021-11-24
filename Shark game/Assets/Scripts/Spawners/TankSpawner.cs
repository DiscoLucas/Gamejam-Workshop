using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public GameObject spawnee;
    public bool stopSpawning = false;
    public float spawnTime;
    public float spawnDelay;
    private static int tanks;

    // Start is called before the first frame update
    void Start()
    {
        tanks = 0;
        InvokeRepeating("SpawnObject", spawnTime, spawnDelay);
    }

    void Update() 
    {
        //Stopper spawn hvis der er 10 eller flere cylindere
        if (tanks >= 10)
        CancelInvoke("SpawnObject");
    }

    public void SpawnObject()
    {   
        Instantiate(spawnee, transform.position, transform.rotation);
        ++tanks;
        //Hvis stop spawning er klikket på i Inspectoren, så spawner den kun 1
        if(stopSpawning)
        {
            CancelInvoke("SpawnObject");
        }
    }
}
