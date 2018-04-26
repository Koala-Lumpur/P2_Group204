using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetailDistance : MonoBehaviour {

    public int detailDistance;
    public Terrain terrain;

	// Use this for initialization
	void Start () {
        terrain.detailObjectDistance = detailDistance;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
