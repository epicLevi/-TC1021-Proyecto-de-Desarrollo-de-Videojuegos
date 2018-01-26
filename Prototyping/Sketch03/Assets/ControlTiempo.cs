using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlTiempo : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float mouseX = Input.GetAxis("Mouse X");
        float mouseY = Input.GetAxis("Mouse Y");
        float targetScale = 0.05f;

        if (mouseX > 0 || mouseY > 0) targetScale = 0.4f;
        if (Input.anyKey) targetScale = 0.8f;

        Time.timeScale = Mathf.Lerp(Time.timeScale, targetScale, 0.5f);
        Time.fixedDeltaTime = 0.02f * Time.timeScale;
    }
}
