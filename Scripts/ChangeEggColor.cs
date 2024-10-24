using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeEggColor : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // colicion con un objeto fisico
    void OnCollisionEnter(Collision collision) {
        if (collision.gameObject.tag == "Group1Spider") {
            Debug.Log("AAAAAAAAAAAAAAAAAAAAAAA");
            GetComponent<Renderer>().material.color = Color.red;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
