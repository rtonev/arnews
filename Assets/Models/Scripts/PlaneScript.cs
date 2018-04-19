using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlaneScript : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}

    void Update()
    {
        transform.up = Camera.main.transform.position - transform.position;
        transform.forward = -Camera.main.transform.up;
    }
}
