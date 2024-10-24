using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group2SpidesScript : MonoBehaviour
{
    public CubeCollisionController checkCollision;
    public GameObject target;
    public float velocity = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        checkCollision.OnCollisionDetectedWithGroup2 += MoveSpiderTo;
    }
    
    void MoveSpiderTo() {
        Debug.Log("Moving Spider to Group2");
        GameObject[] group1_spiders;
        group1_spiders = GameObject.FindGameObjectsWithTag("Group1Spider");
        foreach (GameObject spider in group1_spiders) {
            spider.transform.LookAt(target.transform);
            spider.transform.Translate(Vector3.forward * velocity);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
