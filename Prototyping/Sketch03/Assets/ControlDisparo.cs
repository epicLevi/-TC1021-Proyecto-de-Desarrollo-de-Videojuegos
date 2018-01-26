using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDisparo : MonoBehaviour {
    public GameObject bala;
    public GameObject boca;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetMouseButtonDown(0)) {
            GameObject b = Instantiate(bala, boca.transform.position, boca.transform.rotation) as GameObject;
            b.GetComponent<Rigidbody>().AddForce(-this.transform.forward * 1000);
        }
	}
}
