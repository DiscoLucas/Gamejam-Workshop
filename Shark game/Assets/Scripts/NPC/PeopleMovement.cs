using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PeopleMovement : MonoBehaviour
{
    public float moveSpeed = 3;
    public float rotSpeed = 100;

    private bool iswandering = false;
    private bool isRotatingLeft = false;
    private bool isRotatingRight = false;
    private bool isWalking = false;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Roterer kun når den står stille. rotSpeed bestemmer rotationshastighed. 
        // -rotspeed rotere den modsatte vej
        if(iswandering == false)
        {
            StartCoroutine(Wander());
        }
        if(isRotatingRight == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * rotSpeed);
        }
        if(isRotatingLeft == true)
        {
            transform.Rotate(transform.up * Time.deltaTime * -rotSpeed);
        }
        if(isWalking == true)
        {
            transform.position += transform.forward * moveSpeed * Time.deltaTime;
        }
    }

    IEnumerator Wander()
    {
        // Randomizer tid mellem aktioner og hvor lang tid hver aktion skal tage
        int rotTime = Random.Range(1, 3);
        int rotateWait = Random.Range(1, 2);
        int rotateLorR = Random.Range(1, 2);
        int walkWait = Random.Range(1, 3);
        int walkTime = Random.Range(1, 4);

        iswandering = true;

        yield return new WaitForSeconds(walkWait);
        isWalking = true;
        yield return new WaitForSeconds(walkTime);
        isWalking = false;
        yield return new WaitForSeconds(rotateWait);

        if(rotateLorR == 1)
        {
            isRotatingRight = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingRight = false;
        }

        if(rotateLorR == 2)
        {
            isRotatingLeft = true;
            yield return new WaitForSeconds(rotTime);
            isRotatingLeft = false;
        }
        iswandering = false;
    }
}
