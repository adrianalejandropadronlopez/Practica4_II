using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeCollisionControllerModed : MonoBehaviour
{
    public delegate void CollisionHandler();
    public event CollisionHandler OnCollisionDetectedWithEggPlayer1;

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Egg") {
            if (OnCollisionDetectedWithEggPlayer1 != null) {
                OnCollisionDetectedWithEggPlayer1();
            }
        } 
    }
}
