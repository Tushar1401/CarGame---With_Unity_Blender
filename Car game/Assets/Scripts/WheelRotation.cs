using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WheelRotation : MonoBehaviour
{
    // drag and drop the the wheel collider game object into the slot in the inspector
    public WheelCollider wheelGameObject;
    public float angle;    // assign correct angle in the inspector (90°)
 
    void Awake ()
    {
        wheelGameObject.steerAngle = angle;
    }
}
