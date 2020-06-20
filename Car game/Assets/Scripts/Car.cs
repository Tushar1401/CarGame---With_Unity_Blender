using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    [SerializeField]
    Vector3 v3Force;
    [SerializeField]
    KeyCode keyBrake;


    public Transform centerOfMass;
    public float motorTorque = 1500f;
    public float maxSteer = 20f;

    public WheelCollider wheelColliderLeftFront;
    public WheelCollider wheelColliderRightFront;
    public WheelCollider wheelColliderLeftBack;
    public WheelCollider wheelColliderRighttBack;

    public Transform wheelLeftFront;
    public Transform wheelRightFront;
    public Transform wheelLeftBack;
    public Transform wheelRightBack;
   
    void FixedUpdate()
    {
      wheelColliderLeftBack.motorTorque = Input.GetAxis("Vertical") * motorTorque;
      wheelColliderRighttBack.motorTorque = Input.GetAxis("Vertical") * motorTorque;
      wheelColliderLeftFront.steerAngle = 90 + Input.GetAxis("Horizontal") * maxSteer;
      wheelColliderRightFront.steerAngle = 90 + Input.GetAxis("Horizontal") * maxSteer;
    }
   
    void Update()
    {
       var pos = Vector3.zero;
       var rot = Quaternion.identity;

       wheelColliderLeftFront.GetWorldPose(out pos, out rot);
       wheelLeftFront.position = pos;
       wheelLeftFront.rotation = rot * Quaternion.Euler(0,90,0);

       wheelColliderRightFront.GetWorldPose(out pos, out rot);
       wheelRightFront.position = pos;
       wheelRightFront.rotation = rot * Quaternion.Euler(0,90,0);

       wheelColliderLeftBack.GetWorldPose(out pos, out rot);
       wheelLeftBack.position = pos;
       wheelLeftBack.rotation = rot * Quaternion.Euler(0,90,0);

       wheelColliderRighttBack.GetWorldPose(out pos, out rot);
       wheelRightBack.position = pos;
       wheelRightBack.rotation = rot * Quaternion.Euler(0,90,0);   

         if(Input.GetKey(keyBrake))
           GetComponent<Rigidbody>().velocity = v3Force;     
    }
}
 