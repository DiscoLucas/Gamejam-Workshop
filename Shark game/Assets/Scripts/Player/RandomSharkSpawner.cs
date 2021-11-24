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
        //Starting the method in a private IEnumerator, so the loop can be paused. 
        StartCoroutine(SpawnSharks());
    }

    // Start is called before the first frame update
    void Update()
    {
        //Giving the vector3 variable a random range value, then assigning the random direction to the quaternion variable as value. 
        randomDirection = new Vector3(Random.Range(360f, 5f), 0, Random.Range(360f, 5));
        randDir.eulerAngles = randomDirection;

    }

    private IEnumerator SpawnSharks()
    {
        int totalSharks = 1;
        while(totalSharks < 10) 
        {
            //Instatiating the random sharks, and giving them momentum out from the tornado's position. 
            GameObject newShark = Instantiate(randomShark, this.transform.position, randDir);
            Rigidbody sharkRB = newShark.GetComponent<Rigidbody>();
            sharkRB.velocity = Vector3.forward * sharkSpeed;

            //Command to make the loop pause before playing again
            yield return new WaitForSeconds(2f);

            //Get rid of the instantiated objects
            Destroy(newShark, 2f);
        }
    }
}
