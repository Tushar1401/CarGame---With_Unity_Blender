using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class carVelocity : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;

    [SerializeField]
    KeyCode keyBrake;

    [SerializeField]
    KeyCode keyPos;

    [SerializeField]
    KeyCode keyNeg;
    // Update is called once per frame
    void FixedUpdate()
    {
        if(Input.GetKey(keyBrake))
           GetComponent<Rigidbody>().velocity = v3Force;   
        if(Input.GetKey(keyPos))
           GetComponent<Rigidbody>().velocity += v3Force;     
        if(Input.GetKey(keyNeg))
           GetComponent<Rigidbody>().velocity -= v3Force;  
    }
}
