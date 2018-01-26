using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlDisparoEnemigo : MonoBehaviour {
 	public GameObject bala;

    // Use this for initialization
    void Start () {
		InvokeRepeating("ShootProjectile", 2.0f, 2.0f);
	}
	
	void ShootProjectile() {
		GameObject instance = Instantiate(bala, this.transform.position, this.transform.rotation) as GameObject;
        instance.GetComponent<Rigidbody>().AddForce(-this.transform.forward * 10000);
	}
}
