using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionController : MonoBehaviour
{
    public delegate void CollisionHandler();
    public event CollisionHandler OnCollisionDetectedWithGroup1;
    public event CollisionHandler OnCollisionDetectedWithGroup2;
    public event CollisionHandler OnCollisionDetectedWithEgg;

    void OnTriggerEnter(Collider other)
    {
        Debug.Log("Collision Detected: " + other.gameObject.name);
        if (other.gameObject.tag == "Group1Spider") {
            if (OnCollisionDetectedWithGroup1 != null) {
                OnCollisionDetectedWithGroup1();
            }
        }
        else if (other.gameObject.tag == "Group2Spider") {
            if (OnCollisionDetectedWithGroup2 != null) {
                OnCollisionDetectedWithGroup2();
            }
        } else if (other.gameObject.tag == "Group1Egg" || other.gameObject.tag == "Group2Egg") {
            if (OnCollisionDetectedWithEgg != null) {
                OnCollisionDetectedWithEgg();
            }
        }
    }
}
