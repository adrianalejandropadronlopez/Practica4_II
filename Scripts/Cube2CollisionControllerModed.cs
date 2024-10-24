using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cube2CollisionControllerModed : MonoBehaviour
{
    public delegate void CollisionHandler();
    public event CollisionHandler OnCollisionDetectedWithEggPlayer2;

    void OnTriggerEnter(Collider other) {
        if (other.gameObject.tag == "Egg") {
            if (OnCollisionDetectedWithEggPlayer2 != null) {
                OnCollisionDetectedWithEggPlayer2();
            }
        } 
    }
}
