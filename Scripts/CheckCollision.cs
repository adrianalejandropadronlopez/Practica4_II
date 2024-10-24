using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckCollision : MonoBehaviour
{   
    public delegate void CollisionHandler();
    public event CollisionHandler OnCollisionDetected;
    void OnTriggerEnter(Collider other) {
        Debug.Log("Collision Detected: " + other.gameObject.name);	
        if (OnCollisionDetected != null) {
            OnCollisionDetected();
        }
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
