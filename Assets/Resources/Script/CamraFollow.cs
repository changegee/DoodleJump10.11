using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamraFollow : MonoBehaviour {

    public Transform target;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if(target.position.y > transform.position.y)
        {
            Vector3 newPos = new Vector3(transform.position.x , target.transform.position.y , transform.position.z);
            transform.position = newPos;
        }
	}
}
