using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeCamera : MonoBehaviour {

    public int cameraNumber;
    public Camera camera1;
    public Camera camera2;
    public Camera camera3;
    public Camera camera4;
    public Camera camera5;
    public Camera camera6;
    public Camera camera7;
    public Camera camera8;
    public GameObject text1;
    public GameObject text2;
    public GameObject text3;
    public GameObject text4;
    public GameObject text5;
    public GameObject text6;
    public GameObject text7;
    public GameObject text8;


    // Use this for initialization
    void Start () {

    }
	
	// Update is called once per frame   
	void Update () {
		if(Input.GetMouseButtonDown(0))
        {
            
            cameraNumber++;
            Debug.Log(cameraNumber);
            if (cameraNumber > 7)
            {
                cameraNumber = 0;
            }
            if (cameraNumber == 0)
            {
                camera1.enabled = true;
                camera8.enabled = false;
                text1.SetActive(true);
                text8.SetActive(false);
            }
            else if (cameraNumber == 1)
            {
                camera2.enabled = true;
                camera1.enabled = false;
                text2.SetActive(true);
                text1.SetActive(false);
            }
            else if (cameraNumber == 2)
            {
                camera3.enabled = true;
                camera2.enabled = false;
                text3.SetActive(true);
                text2.SetActive(false);
            }
            else if (cameraNumber == 3)
            {
                camera4.enabled = true;
                camera3.enabled = false;
                text4.SetActive(true);
                text3.SetActive(false);
            }
            else if (cameraNumber == 4)
            {
                camera5.enabled = true;
                camera4.enabled = false;
                text5.SetActive(true);
                text4.SetActive(false);
            }
            else if (cameraNumber == 5)
            {
                camera6.enabled = true;
                camera5.enabled = false;
                text6.SetActive(true);
                text5.SetActive(false);
            }
            else if (cameraNumber == 6)
            {
                camera7.enabled = true;
                camera6.enabled = false;
                text7.SetActive(true);
                text6.SetActive(false);
            }
            else if (cameraNumber == 7)
            {
                camera8.enabled = true;
                camera7.enabled = false;
                text8.SetActive(true);
                text7.SetActive(false);
            }
        }
        
	}
}
