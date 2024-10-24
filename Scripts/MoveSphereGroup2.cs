using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphereGroup2 : MonoBehaviour
{   

    [Header ("Velocity")]  
    public float velocity = 1;
    public CheckCollision checkCollision;
    // Start is called before the first frame update
    void Start()
    {
        checkCollision.OnCollisionDetected += MoveSphereTo;
    }
    
    void MoveSphereTo() {
        this.transform.LookAt(GameObject.Find("Cylinder").transform);
        this.transform.Translate(Vector3.forward * Time.deltaTime * velocity);
    }
}
