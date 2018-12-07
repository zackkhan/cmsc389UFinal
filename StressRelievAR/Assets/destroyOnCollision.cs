using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using HoloToolkit.Unity.InputModule;

public class destroyOnCollision : MonoBehaviour {

    // Use this for initialization
    public GameObject BrokenVersion;
    private Rigidbody rb;
    public GameObject MRCam;

    void OnCollisionEnter(Collision col)
    {
        if (col.relativeVelocity.magnitude > 2) { 
            Instantiate(BrokenVersion, transform.position, transform.rotation);
            Destroy(gameObject);
        }
        
    }
    
    private HandDraggable script;
    // Use this for initialization
    void Start()
    {
        HandDraggable script = GetComponent<HandDraggable>();
        Rigidbody rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {

    }

    public void crushObj()
    {
        if (script.isCurrDragging())
        {
            script.StopDragging();
            Instantiate(BrokenVersion, transform.position, transform.rotation);
            Destroy(transform.root.gameObject); //getting the parent-actually idk why
        }
    }

    public void tossObj()
    {
        if (script.isCurrDragging())
        {
            script.StopDragging();
            rb.AddForce(MRCam.transform.forward * 200);
        }
    }
    public void throwObj()
    {
        if (script.isCurrDragging())
        {
            script.StopDragging();
            rb.AddForce(MRCam.transform.forward * 500);
        }
    }



}
