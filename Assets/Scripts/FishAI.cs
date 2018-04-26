using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FishAI : MonoBehaviour {

    public float sensorLength = 20.0f;
    public float sideSensorLength = 5.0f;
    public float speed = 0.01f;
    public float directionValue = 1f;
    public float turnValue = 0.0f;
    public float turnSpeed = 0.1f;
    Collider myCollider;

    // Use this for initialization
    void Start () {
        myCollider = transform.GetComponent<Collider>();
    }
	
	// Update is called once per frame
	void Update () {

        RaycastHit hit;
        int flag = 0;

        //back sensor
        /*if (Physics.Raycast(transform.position, transform.right, out hit, (sensorLength + transform.localScale.z))){
            if(hit.collider.tag != "Obstacle" || hit.collider == myCollider)
            {
                return;
            }

            if (directionValue == 1.0f)
            {
                directionValue = 1;
            }
            
            flag++;

            

        }*/

        //Front sensor
        if (Physics.Raycast(transform.position, -transform.right, out hit, (sensorLength + transform.localScale.z)))
        {
            if (hit.collider.tag != "Obstacle" || hit.collider == myCollider)
            {
                return;
            }
            
            transform.Rotate(0, 180, 0);
            
            flag++;

        }

        //Right sensor
        if (Physics.Raycast(transform.position, transform.forward, out hit, (sensorLength + transform.localScale.x)))
        {
            if (hit.collider.tag != "Obstacle" || hit.collider == myCollider)
            {
                return;
            }

            turnValue -= 1;
            flag++;
        }

        //Left sensor
        if (Physics.Raycast(transform.position, -transform.forward, out hit, (sensorLength + transform.localScale.x)))
        {
            if (hit.collider.tag != "Obstacle" || hit.collider == myCollider)
            {
                return;
            }

            turnValue += 1;
            flag++;
        }


        if (flag == 0)
        {
            turnValue = 0;
        }

        transform.Rotate(Vector3.up * (turnSpeed * turnValue));

        transform.position += -transform.right * (speed * directionValue);

    }
}
