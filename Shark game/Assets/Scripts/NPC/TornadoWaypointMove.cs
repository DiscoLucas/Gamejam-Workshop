using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TornadoWaypointMove : MonoBehaviour
{
    public Transform[] wayPoints;
    public int speed;

    private int waypointIndex;
    private float dist;
    // Start is called before the first frame update
    void Start()
    {
        waypointIndex = 0;
        // Får AI til at kigge på waypoint, så når den bevæger sig fremad, vil den altid gå mod et waypoint
        transform.LookAt(wayPoints[waypointIndex].position);
    }

    // Update is called once per frame
    void Update()
    {
        dist = Vector3.Distance(transform.position, wayPoints[waypointIndex].position);
        if(dist < 1f)
        {
            IncreseIndex();
        }
        patrol();
    }

    void patrol()
    {
        transform.Translate(Vector3.forward * speed * Time.deltaTime);
    }

    void IncreseIndex()
    {
        waypointIndex++;
        // reseter waypointIndex til 0 hvis den er større eller i lig array'en af wayPoints
        if(waypointIndex >= wayPoints.Length)
        {
            waypointIndex= 0;
        }
        transform.LookAt(wayPoints[waypointIndex].position);
    }
}
