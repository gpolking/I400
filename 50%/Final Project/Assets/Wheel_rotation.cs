using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wheel_rotation : MonoBehaviour {

	// Use this for initialization
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(Vector3.up * Time.deltaTime);
    }
}
