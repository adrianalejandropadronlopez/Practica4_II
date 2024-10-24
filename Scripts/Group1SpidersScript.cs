using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Group1SpidersScript : MonoBehaviour
{
    public CubeCollisionController checkCollision;   
    public float velocity = 1.0f;
    // Start is called before the first frame update
    void Start()
    {
        checkCollision.OnCollisionDetectedWithGroup1 += MoveSpiderTo;
    }

    void MoveSpiderTo() {
        GameObject[] group1_spiders;
        group1_spiders = GameObject.FindGameObjectsWithTag("Group1Spider");
        foreach (GameObject spider in group1_spiders) {
            GameObject closestEgg = FindClosestEgg(spider);
            if (closestEgg != null) {  
                spider.transform.LookAt(closestEgg.transform);  
                spider.transform.Translate(Vector3.forward * velocity);
            }
        }
        
    }

    GameObject FindClosestEgg(GameObject spider) {
        GameObject[] eggs = GameObject.FindGameObjectsWithTag("Group2Egg");
        GameObject closestEgg = null;
        float minDistance = 999999;
        foreach (GameObject egg in eggs) {
            float distance = Vector3.Distance(spider.transform.position, egg.transform.position);
            if (distance < minDistance) {
                closestEgg = egg;
                minDistance = distance;
            }
        }
        return closestEgg;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
