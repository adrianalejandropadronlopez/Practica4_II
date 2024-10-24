using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveSphere : MonoBehaviour
{
    [Header ("Velocity")]
    public float velocity = 1;

    [Header ("Objetive Sphere")]
    public GameObject sphere;
    public CheckCollision checkCollision;
    // Start is called before the first frame update
    void Start()
    {
        checkCollision.OnCollisionDetected += MoveSphereTo;
    }

    void MoveSphereTo() {
        this.transform.LookAt(sphere.transform);
        this.transform.Translate(Vector3.forward * Time.deltaTime * velocity);
    }
}
