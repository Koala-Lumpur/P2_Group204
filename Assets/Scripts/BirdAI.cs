using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAI : MonoBehaviour {

    public Transform[] path;
    public float speed;
    public float reachDist;
    public int currentPoint;
    private Vector3 dir;


    void Start()
    {
        dir = path[currentPoint].position - transform.position;
    }

    void Update()
    {
        

        transform.position += dir * speed;

        if(dir.magnitude <= reachDist)
        {
            PointReached();
        }
    }

    void PointReached()
    {
        currentPoint++;
        dir = path[currentPoint].position - transform.position;
    }
}
