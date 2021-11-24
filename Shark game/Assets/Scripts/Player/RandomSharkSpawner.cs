using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSharkSpawner : MonoBehaviour
{
    private Vector3 randomDirection;
    private Quaternion randDir;
    public GameObject randomShark;
    private float sharkSpeed = 20f;

    private void Start()
    {
        StartCoroutine(SpawnSharks());
    }

    // Start is called before the first frame update
    void Update()
    {
        randomDirection = new Vector3(Random.Range(360f, 5f), 0, Random.Range(360f, 5));
        randDir.eulerAngles = randomDirection;

  
    }

    private IEnumerator SpawnSharks()
    {
        int totalSharks = 1;
        while(totalSharks < 10) 
        {
            GameObject newShark = Instantiate(randomShark, this.transform.position, randDir);
            Rigidbody sharkRB = newShark.GetComponent<Rigidbody>();
            sharkRB.velocity = Vector3.forward * sharkSpeed;
            yield return new WaitForSeconds(2f);
        }
    }
}
