using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeNear : MonoBehaviour
{   
    public delegate void NearHandler();
    public event NearHandler OnNearArea;
    GameObject cube;
    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.FindGameObjectWithTag("Cube");
        if (cube == null) {
            Debug.LogError("Cube not found");
        }
    }

    // Update is called once per frame
    void Update() {
        float distance = Vector3.Distance(transform.position, cube.transform.position);
        if (distance < 5) {
            if (OnNearArea != null) {
                OnNearArea();
            }
        }
    }
}
