using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Explosion : MonoBehaviour {

    // Use this for initialization
    private Rigidbody rb;
    void Start () {
        rb = GetComponent<Rigidbody>();
    }
    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Explode"))
        {
            other.gameObject.SetActive(true);
        }
    }
    // Update is called once per frame
    
}
