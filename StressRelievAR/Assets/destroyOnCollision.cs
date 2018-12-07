using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class destroyOnCollision : MonoBehaviour {

    // Use this for initialization
    public GameObject BrokenVersion;

    void OnCollisionEnter(Collision col)
    {
        if (col.relativeVelocity.magnitude > 2) { 
            Instantiate(BrokenVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }
    // Update is called once per frame
    void Update () {

        
    }
}
