using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BirdAI : MonoBehaviour {

    public Transform[] path;
    public float speed;
    public float rotationSpeed;
    public float reachDist;
    public int currentPoint;
    private Vector3 dir;


    void Start()
    {
        dir = path[currentPoint].position - transform.position;
    }

    void Update()
    {
        Debug.Log(path[currentPoint]);
        //dir = path[currentPoint].position - transform.position;
        //Vector3 rotateToTarget = Vector3.RotateTowards(-transform.right, dir, speed, 10000);
        Quaternion q = Quaternion.LookRotation(dir) * Quaternion.Euler(0, 90, 0);

        //Debug.DrawRay(transform.position, path[currentPoint].position, Color.red);


        transform.rotation = Quaternion.RotateTowards(transform.rotation, q, rotationSpeed);

        transform.position = Vector3.MoveTowards(transform.position, path[currentPoint].position, speed);

        if(Vector3.Distance(transform.position, path[currentPoint].position) < reachDist)
        {
            PointReached();
        }

        
    }

    void PointReached()
    {
        if (currentPoint >= path.Length - 1)
        {
            currentPoint = 0;
        } else
        {
            currentPoint++;
        }
        
        dir = path[currentPoint].position - transform.position;
    }
}